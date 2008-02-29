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
    public partial class frmEdit : Form
    {
        public bool allowClosed = false;

        private bool errFoundContact = false;

        private string _hldrName;
        private string _hldrTel;

        public frmEdit()
        {
            InitializeComponent();
        }

        public string hldrName
        {
            set
            {
                _hldrName = value;
            }
        }

        public string hldrTel
        {
            set
            {
                _hldrTel = value;
            }
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
                btnEdit.Enabled = true;
            else
                btnEdit.Enabled = false;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_hldrName != txtName.Text.Trim() ? (!FoundContact()) : true)
            {
                DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â ÊÌ—«Ì‘  „«” „Ê—œ ‰Ÿ— „Ì »«‘Ìœ", Base.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.OK:
                        string tbl = "contactlist";
                        string sqlStr = "SELECT * FROM " + tbl;

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

                            oda.Fill(ds, tbl);

                            int id = -1;

                            string encName = EncDec.Encrypt(_hldrName, Base.hashKey);

                            while (drr.Read())
                            {
                                ++id;
                                if (drr["name"].ToString().Trim() == encName)
                                {
                                    dt = ds.Tables[tbl];
                                    dr = dt.Rows[id];
                                    dr.BeginEdit();
                                    dr["name"] = EncDec.Encrypt(txtName.Text.Trim(), Base.hashKey);
                                    dr["tel"] = EncDec.Encrypt(txtTel.Text.Trim(), Base.hashKey);
                                    dr.EndEdit();

                                    oda.UpdateCommand = ocb.GetUpdateCommand();

                                    if (oda.Update(ds, tbl) == 1)
                                        ds.AcceptChanges();
                                    else
                                        ds.RejectChanges();
                                }
                            }

                            drr.Close();
                            drr.Dispose();
                            drr = null;

                            MessageBox.Show(" „«” „Ê—œ ‰Ÿ— »« „Ê›ﬁÌ  ÊÌ—«Ì‘ ‘œ", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CloseDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        break;
                    default:
                        break;
                }
            }
            else if (!errFoundContact)
            {
                MessageBox.Show(" „«” „Ê—œ ‰Ÿ— ﬁ»·« À»  ‘œÂ «” ", Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtName.SelectAll();
                txtName.Focus();
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtName.Text = _hldrName;
            txtTel.Text = _hldrTel;
        }
    }
}