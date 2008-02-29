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
    public partial class frmPw : Form
    {
        private bool _isValid = false;
        private string pw = string.Empty;
        
        public frmPw()
        {
            InitializeComponent();

            pw = GetPw();
            chk();
        }

        public bool isValid
        {
            get
            {
                return _isValid;
            }
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
                Environment.Exit(Environment.ExitCode);
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

        private void chk()
        {
            if (pw == txtPw.Text.Trim())
            {
                _isValid = true;
                this.Close();
                this.Dispose();
            }
        }

        private void frmPw_Shown(object sender, EventArgs e)
        {
            txtPw.Focus();
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            chk();
        }

        private void frmPw_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ControlBox)
                e.Cancel = true;
        }
    }
}