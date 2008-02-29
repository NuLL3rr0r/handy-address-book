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
    public partial class frmNew : Form
    {
        public bool allowClosed = false;

        private bool errFoundContact = false;

        public frmNew()
        {
            InitializeComponent();
        }

        private void CloseDialog()
        {
            allowClosed = true;
            this.Close();
            this.Dispose();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CloseDialog();
        }

        private void frmNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClosed)
                e.Cancel = true;
        }

        private void chkCanInsert()
        {
            if (txtName.Text.Trim() != string.Empty && txtTel.Text != string.Empty)
                btnInsert.Enabled = true;
            else
                btnInsert.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            chkCanInsert();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            chkCanInsert();
        }

        private bool FoundContact()
        {
            string tbl = "contactlist";
            string sqlStr = "SELECT * FROM " + tbl;

            OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
            OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
            OleDbCommand cmd = new OleDbCommand(sqlStr, cnn);

            DataSet ds = new DataSet();

            try
            {
                cnn.Open();
                OleDbDataReader drr = cmd.ExecuteReader();

                oda.Fill(ds, tbl);

                string encName = EncDec.Encrypt(txtName.Text.Trim(), Base.hashKey);

                while (drr.Read())
                {
                    if (drr["name"].ToString().Trim() == encName)
                    {
                        return true;
                    }
                }
                drr.Close();
                drr.Dispose();
                drr = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                errFoundContact = true;
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

            return false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!FoundContact())
            {
                string tbl = "contactlist";
                string sqlStr = "SELECT * FROM " + tbl;

                OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
                OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
                cnn.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataRow dr;

                try
                {
                    ocb.QuotePrefix = "[";
                    ocb.QuoteSuffix = "]";
                    oda.Fill(ds, tbl);

                    dt = ds.Tables[tbl];
                    dr = dt.NewRow();
                    dr["name"] = EncDec.Encrypt(txtName.Text.Trim(), Base.hashKey);
                    dr["tel"] = EncDec.Encrypt(txtTel.Text.Trim(), Base.hashKey);
                    dt.Rows.Add(dr);

                    oda.InsertCommand = ocb.GetInsertCommand();

                    if (oda.Update(ds, tbl) == 1)
                        ds.AcceptChanges();
                    else
                        ds.RejectChanges();

                    MessageBox.Show(" „«” ÃœÌœ »« „Ê›ﬁÌ  «÷«›Â ‘œ", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtTel.Clear();
                    txtName.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlStr = null;

                    ds.Dispose();
                    ocb.Dispose();
                    oda.Dispose();
                    cnn.Dispose();
                    dt.Dispose();

                    ds = null;
                    ocb = null;
                    oda = null;
                    dr = null;
                    dt = null;
                    cnn = null;
                }
            }
            else if (!errFoundContact)
                MessageBox.Show(" „«” „Ê—œ ‰Ÿ— ﬁ»·« À»  ‘œÂ «” ", Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}