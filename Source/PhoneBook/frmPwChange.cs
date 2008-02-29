using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PhoneBook
{
    public partial class frmPwChange : Form
    {
        public bool allowClosed = false;

        public frmPwChange()
        {
            InitializeComponent();
        }

        private void CloseDialog()
        {
            allowClosed = true;
            this.Close();
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void frmPwChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClosed)
                e.Cancel = true;
        }

        private string GetPw()
        {
            string pw = string.Empty;
            string sqlStr = "SELECT * FROM admin";

            OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
            OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
            OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);

            DataSet ds = new DataSet();

            try
            {
                cnn.Open();
                OleDbDataReader drr = cmd.ExecuteReader();

                oda.Fill(ds, "admin");

                while (drr.Read())
                {
                    pw = EncDec.Decrypt(drr["pw"].ToString().Trim(), Base.hashKey);
                    break;
                }

                drr.Close();
                drr.Dispose();
                drr = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlStr = null;

                cnn.Close();

                cmd.Dispose();
                ds.Dispose();
                oda.Dispose();
                cnn.Dispose();

                cmd = null;
                ds = null;
                oda = null;
                cnn = null;
            }

            return pw;
        }

        public bool SetPw(string npw)
        {
            string sqlStr = "SELECT * FROM admin";

            OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
            OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
            OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
            OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;

            try
            {
                cnn.Open();
                OleDbDataReader drr = cmd.ExecuteReader();

                ocb.QuotePrefix = "[";
                ocb.QuoteSuffix = "]";
                oda.Fill(ds, "admin");

                while (drr.Read())
                {
                    dt = ds.Tables["admin"];
                    dr = dt.Rows[0];
                    dr.BeginEdit();
                    dr["pw"] = EncDec.Encrypt(npw.Trim(), Base.hashKey);
                    dr.EndEdit();

                    oda.UpdateCommand = ocb.GetUpdateCommand();

                    if (oda.Update(ds, "admin") == 1)
                        ds.AcceptChanges();
                    else
                        ds.RejectChanges();
                    break;
                }
                drr.Close();
                drr.Dispose();
                drr = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlStr = null;

                cnn.Close();

                cmd.Dispose();
                ds.Dispose();
                ocb.Dispose();
                oda.Dispose();
                cnn.Dispose();
                dt.Dispose();

                cmd = null;
                ds = null;
                ocb = null;
                oda = null;
                dr = null;
                dt = null;
                cnn = null;
            }

            return true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (txtNewPw.Text == txtConfirmPw.Text)
            {
                string pw = GetPw();
                if (pw == txtCurrentPw.Text)
                {
                    if (SetPw(txtNewPw.Text))
                    {
                        MessageBox.Show("ﬂ·„Â Ì ⁄»Ê— ÃœÌœ »« „Ê›ﬁÌ  Ã«Ìê“Ì‰ ‘œ", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseDialog();
                    }
                }
                else
                    MessageBox.Show("·ÿ›« ﬂ·„Â ⁄»Ê— ›⁄·Ì —« Ê«—œ ‰„«∆Ìœ", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("·ÿ›« ﬂ·„Â Ì ⁄»Ê— ÃœÌœ —«  «∆Ìœ ‰„«∆Ìœ", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPw.Focus();
                txtConfirmPw.SelectAll();
            }
        }
    }
}