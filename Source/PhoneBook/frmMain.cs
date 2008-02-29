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
    public partial class frmMain : Form
    {
        private string errDb = "امكان دسترسي به پايگاه داده ها وجود ندارد";
        private bool pwCtrl = true;

        private DataTable dtMaster = new DataTable();

        public frmMain()
        {
            InitializeComponent();

            if (!ChkFiles(Base.fileDb, errDb))
            {
                Environment.Exit(Environment.ExitCode);
            }
        }

        private bool ChkFiles(string file, string errMsg)
        {
            bool found = File.Exists(file);
            if (!found)
            {
                MessageBox.Show(string.Concat(errMsg, "\n\nDetails:\n", file, "\t...Not Found"), Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return found;
        }

        private void Protect()
        {
            try
            {
                using (frmPw dlg = new frmPw())
                {
                    if (!pwCtrl)
                        dlg.ControlBox = false;

                    dlg.ShowDialog(this.ParentForm);
                    if (!dlg.isValid) Environment.Exit(Environment.ExitCode);

                    pwCtrl = false;
                }
                this.Focus();
            }
            catch
            {
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            Protect();
            ResetContacts();
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            using (frmPwChange dlg = new frmPwChange())
            {
                dlg.ShowDialog(this.ParentForm);
            }
        }

        private void ClearContacts()
        {
            this.Focus();
            txtSearch.Clear();
            dgvContactList.DataSource = null;
            this.Focus();
        }

        private void ResetContacts()
        {
            this.Focus();
            mItemEdit.Enabled = false;
            mItemErase.Enabled = false;

            dtMaster = FillContacts();

            dtMaster.Columns[0].ColumnName = "نام";
            dtMaster.Columns[1].ColumnName = "شماره تماس";

/*            dtMaster.Columns[0].ColumnName = "رديف";
            dtMaster.Columns[1].ColumnName = "نام";
            dtMaster.Columns[2].ColumnName = "شماره تماس";*/

            dgvContactList.DataSource = dtMaster;

            dgvContactList.Columns[0].Width = 222;
            dgvContactList.Columns[1].Width = 222;

/*            dgvContactList.Columns[0].Width = 44;
            dgvContactList.Columns[1].Width = 222;
            dgvContactList.Columns[2].Width = 178;*/

            dgvContactList.Sort(dgvContactList.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            this.Focus();
            txtSearch.Focus();
        }

        private DataTable FillContacts()
        {
            string pw = string.Empty;
            string sqlStr = "SELECT * FROM contactlist";

            OleDbConnection cnn = new OleDbConnection(Base.cnnStr);
            OleDbDataAdapter oda = new OleDbDataAdapter(sqlStr, cnn);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataRow dr;

            try
            {
                cnn.Open();

                oda.Fill(ds, "contactlist");

                dt = ds.Tables["contactlist"];
                dt.Columns.Remove("index");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    dr.BeginEdit();
                    dr["name"] = EncDec.Decrypt(dr["name"].ToString().Trim(), Base.hashKey);
                    dr["tel"] = EncDec.Decrypt(dr["tel"].ToString().Trim(), Base.hashKey);
                    dr.EndEdit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Base.msgErrTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlStr = null;

                cnn.Close();

                ds.Dispose();
                oda.Dispose();
                cnn.Dispose();

                ds = null;
                oda = null;
                cnn = null;
            }

            return dt;
        }

        private void ctxReturn_Click(object sender, EventArgs e)
        {
            ntfyMinimize.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ctxTimeSinceReboot_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat("حدودا ", ((Int32)((Environment.TickCount / 1000) / 60)).ToString(), " دقيقه از زمان بوت ويندوز مي گذرد"), "آخرين بوت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctxCurrentOSVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat("OS Version: ", Environment.OSVersion.ToString()), "Operating System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctxFrameworkVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat("Framework Version: ", Environment.Version.ToString()), ".NET Framework Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctxCurrentTimeZone_Click(object sender, EventArgs e)
        {
            if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now))
                MessageBox.Show(string.Concat(TimeZone.CurrentTimeZone.DaylightName, " :منطقه زماني فعلي سيستم"), "منطقه زماني", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(string.Concat(TimeZone.CurrentTimeZone.StandardName, " :منطقه زماني فعلي سيستم"), "منطقه زماني", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctxCurrentDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Concat(DateTime.Now.ToLongDateString(), "   ", DateTime.Now.ToLongTimeString(), "       ", Base.GetPersianDate(), " :تاريخ شمسي"), "تاريخ و ساعت", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ctxExit_Click(object sender, EventArgs e)
        {
            ntfyMinimize.Visible = false;
            Environment.Exit(Environment.ExitCode);
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                ntfyMinimize.Visible = true;
            }
        }

        private void ntfyMinimize_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ntfyMinimize.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void mItemChangePw_Click(object sender, EventArgs e)
        {
            using (frmPwChange dlg = new frmPwChange())
            {
                dlg.ShowDialog(this.ParentForm);
            }
        }

        private void mItemAbout_Click(object sender, EventArgs e)
        {
            using (frmAbout dlg = new frmAbout())
            {
                dlg.ShowDialog(this.ParentForm);
            }
        }

        private void mItemProtect_Click(object sender, EventArgs e)
        {
            ClearContacts();
            Protect();
            ResetContacts();
        }

        private void mItemSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
            txtSearch.Focus();
        }

        private void mItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void mItemNew_Click(object sender, EventArgs e)
        {
            ClearContacts();
            using (frmNew dlg = new frmNew())
            {
                dlg.ShowDialog(this.ParentForm);
            }
            ResetContacts();
        }

        private void dgvContactList_CurrentCellChanged(object sender, EventArgs e)
        {
            mItemEdit.Enabled = true;
            mItemErase.Enabled = true;
        }

        private void mItemErase_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آيا مايل به حذف تماس مورد نظر مي باشيد", Base.msgTitle, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.OK:
                    string name = dgvContactList.CurrentRow.Cells[0].Value.ToString().Trim();
                    //string name = dgvContactList.CurrentRow.Cells[1].Value.ToString().Trim();
                    ClearContacts();
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

                        string encName = EncDec.Encrypt(name, Base.hashKey);

                        while (drr.Read())
                        {
                            ++id;
                            if (drr["name"].ToString().Trim() == encName)
                            {
                                dt = ds.Tables[tbl];
                                dr = dt.Rows[id];
                                dr.Delete();

                                oda.DeleteCommand = ocb.GetDeleteCommand();

                                if (oda.Update(ds, tbl) == 1)
                                    ds.AcceptChanges();
                                else
                                    ds.RejectChanges();
                            }
                        }

                        drr.Close();
                        drr.Dispose();
                        drr = null;

                        MessageBox.Show("تماس مورد نظر با موفقيت حذف شد", Base.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        ResetContacts();
                    }
                    break;
                default:
                    break;
            }
        }

        private void mItemEdit_Click(object sender, EventArgs e)
        {
            using (frmEdit dlg = new frmEdit())
            {
                dlg.hldrName = dgvContactList.CurrentRow.Cells[0].Value.ToString().Trim();
                dlg.hldrTel = dgvContactList.CurrentRow.Cells[1].Value.ToString().Trim();
                //dlg.hldrName = dgvContactList.CurrentRow.Cells[1].Value.ToString().Trim();
                //dlg.hldrTel = dgvContactList.CurrentRow.Cells[2].Value.ToString().Trim();
                ClearContacts();
                dlg.ShowDialog(this.ParentForm);
            }
            ResetContacts();
        }

        private bool IsNumeric(string str)
        {
            for (int i = 0; i < str.Length; i++)
                switch (str.Substring(i, 1))
                {
                    case "0":
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    default:
                        return false;
                }

            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string phrase = txtSearch.Text.Trim();
            if (phrase != string.Empty)
            {
                DataTable dt = dtMaster.Clone();
                for (int i = 0; i < dtMaster.Rows.Count; i++)
                {
                    byte col;
                    if (!IsNumeric(phrase))
                        col = 0;
                    else
                        col = 1;

                    if (dtMaster.Rows[i][col].ToString().Trim().IndexOf(phrase) > -1)
                    {
                        object[] row = dtMaster.Rows[i].ItemArray;
                        dt.Rows.Add(row);
                    }
                }
                dgvContactList.DataSource = dt;
                dgvContactList.Sort(dgvContactList.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else
                dgvContactList.DataSource = dtMaster;
        }
    }
}