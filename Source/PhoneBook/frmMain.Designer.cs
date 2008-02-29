namespace PhoneBook
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mItemContactList = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemErase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemPw = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemProtect = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemChangePw = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfyMinimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMinimize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxTimeSinceReboot = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCurrentOSVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFrameworkVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCurrentTimeZone = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCurrentDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.ctxMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContactList
            // 
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Location = new System.Drawing.Point(12, 54);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.ReadOnly = true;
            this.dgvContactList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvContactList.Size = new System.Drawing.Size(516, 298);
            this.dgvContactList.TabIndex = 0;
            this.dgvContactList.CurrentCellChanged += new System.EventHandler(this.dgvContactList_CurrentCellChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 27);
            this.txtSearch.MaxLength = 35;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(516, 21);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemContactList,
            this.mItemSearch,
            this.mItemPw,
            this.mItemAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuMain.Size = new System.Drawing.Size(540, 24);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mItemContactList
            // 
            this.mItemContactList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemNew,
            this.mItemEdit,
            this.mItemErase,
            this.toolStripMenuItem4,
            this.mItemExit});
            this.mItemContactList.Name = "mItemContactList";
            this.mItemContactList.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mItemContactList.Size = new System.Drawing.Size(77, 20);
            this.mItemContactList.Text = "·Ì”   „«”";
            // 
            // mItemNew
            // 
            this.mItemNew.Name = "mItemNew";
            this.mItemNew.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mItemNew.Size = new System.Drawing.Size(126, 22);
            this.mItemNew.Text = "ÃœÌœ";
            this.mItemNew.Click += new System.EventHandler(this.mItemNew_Click);
            // 
            // mItemEdit
            // 
            this.mItemEdit.Enabled = false;
            this.mItemEdit.Name = "mItemEdit";
            this.mItemEdit.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.mItemEdit.Size = new System.Drawing.Size(126, 22);
            this.mItemEdit.Text = "ÊÌ—«Ì‘";
            this.mItemEdit.Click += new System.EventHandler(this.mItemEdit_Click);
            // 
            // mItemErase
            // 
            this.mItemErase.Enabled = false;
            this.mItemErase.Name = "mItemErase";
            this.mItemErase.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.mItemErase.Size = new System.Drawing.Size(126, 22);
            this.mItemErase.Text = "Õ–›";
            this.mItemErase.Click += new System.EventHandler(this.mItemErase_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(123, 6);
            // 
            // mItemExit
            // 
            this.mItemExit.Name = "mItemExit";
            this.mItemExit.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.mItemExit.Size = new System.Drawing.Size(126, 22);
            this.mItemExit.Text = "Œ—ÊÃ";
            this.mItemExit.Click += new System.EventHandler(this.mItemExit_Click);
            // 
            // mItemSearch
            // 
            this.mItemSearch.Name = "mItemSearch";
            this.mItemSearch.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mItemSearch.Size = new System.Drawing.Size(75, 20);
            this.mItemSearch.Text = "Ã” ÃÊ   F3";
            this.mItemSearch.Click += new System.EventHandler(this.mItemSearch_Click);
            // 
            // mItemPw
            // 
            this.mItemPw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemProtect,
            this.mItemChangePw});
            this.mItemPw.Name = "mItemPw";
            this.mItemPw.Size = new System.Drawing.Size(64, 20);
            this.mItemPw.Text = "ﬂ·„Â ⁄»Ê—";
            // 
            // mItemProtect
            // 
            this.mItemProtect.Name = "mItemProtect";
            this.mItemProtect.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mItemProtect.Size = new System.Drawing.Size(189, 22);
            this.mItemProtect.Text = "„Õ«›Ÿ  »« ﬂ·„Â ⁄»Ê—";
            this.mItemProtect.Click += new System.EventHandler(this.mItemProtect_Click);
            // 
            // mItemChangePw
            // 
            this.mItemChangePw.Name = "mItemChangePw";
            this.mItemChangePw.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mItemChangePw.Size = new System.Drawing.Size(189, 22);
            this.mItemChangePw.Text = " €ÌÌ— ﬂ·„Â ⁄»Ê—";
            this.mItemChangePw.Click += new System.EventHandler(this.mItemChangePw_Click);
            // 
            // mItemAbout
            // 
            this.mItemAbout.Name = "mItemAbout";
            this.mItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mItemAbout.Size = new System.Drawing.Size(64, 20);
            this.mItemAbout.Text = "œ—»«—Â   F1";
            this.mItemAbout.Click += new System.EventHandler(this.mItemAbout_Click);
            // 
            // ntfyMinimize
            // 
            this.ntfyMinimize.ContextMenuStrip = this.ctxMinimize;
            this.ntfyMinimize.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyMinimize.Icon")));
            this.ntfyMinimize.Text = "»—«Ì ‰„«Ì‘ „Ãœœ œ«»· ﬂ·Ìﬂ ﬂ‰Ìœ";
            this.ntfyMinimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyMinimize_MouseDoubleClick);
            // 
            // ctxMinimize
            // 
            this.ctxMinimize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxReturn,
            this.toolStripMenuItem1,
            this.ctxTimeSinceReboot,
            this.ctxCurrentOSVersion,
            this.ctxFrameworkVersion,
            this.ctxCurrentTimeZone,
            this.ctxCurrentDate,
            this.toolStripMenuItem2,
            this.ctxExit});
            this.ctxMinimize.Name = "ctxMinimize";
            this.ctxMinimize.Size = new System.Drawing.Size(230, 170);
            // 
            // ctxReturn
            // 
            this.ctxReturn.Name = "ctxReturn";
            this.ctxReturn.Size = new System.Drawing.Size(229, 22);
            this.ctxReturn.Text = "»«“ê‘  »Â »—‰«„Â";
            this.ctxReturn.Click += new System.EventHandler(this.ctxReturn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // ctxTimeSinceReboot
            // 
            this.ctxTimeSinceReboot.Name = "ctxTimeSinceReboot";
            this.ctxTimeSinceReboot.Size = new System.Drawing.Size(229, 22);
            this.ctxTimeSinceReboot.Text = "„œ  “„«‰Ì ﬂÂ Ê«—œ ÊÌ‰œÊ“ ‘œÂ «Ìœ";
            this.ctxTimeSinceReboot.Click += new System.EventHandler(this.ctxTimeSinceReboot_Click);
            // 
            // ctxCurrentOSVersion
            // 
            this.ctxCurrentOSVersion.Name = "ctxCurrentOSVersion";
            this.ctxCurrentOSVersion.Size = new System.Drawing.Size(229, 22);
            this.ctxCurrentOSVersion.Text = "‰”ŒÂ ”Ì” „ ⁄«„· ›⁄·Ì ‘„«";
            this.ctxCurrentOSVersion.Click += new System.EventHandler(this.ctxCurrentOSVersion_Click);
            // 
            // ctxFrameworkVersion
            // 
            this.ctxFrameworkVersion.Name = "ctxFrameworkVersion";
            this.ctxFrameworkVersion.Size = new System.Drawing.Size(229, 22);
            this.ctxFrameworkVersion.Text = "‰”ŒÂ ›⁄·Ì dotNET Framework";
            this.ctxFrameworkVersion.Click += new System.EventHandler(this.ctxFrameworkVersion_Click);
            // 
            // ctxCurrentTimeZone
            // 
            this.ctxCurrentTimeZone.Name = "ctxCurrentTimeZone";
            this.ctxCurrentTimeZone.Size = new System.Drawing.Size(229, 22);
            this.ctxCurrentTimeZone.Text = "„‰ÿﬁÂ “„«‰Ì ›⁄·Ì";
            this.ctxCurrentTimeZone.Click += new System.EventHandler(this.ctxCurrentTimeZone_Click);
            // 
            // ctxCurrentDate
            // 
            this.ctxCurrentDate.Name = "ctxCurrentDate";
            this.ctxCurrentDate.Size = new System.Drawing.Size(229, 22);
            this.ctxCurrentDate.Text = " «—ÌŒ Ê ”«⁄  ›⁄·Ì";
            this.ctxCurrentDate.Click += new System.EventHandler(this.ctxCurrentDate_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(229, 22);
            this.ctxExit.Text = "Œ—ÊÃ";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 364);
            this.Controls.Add(this.dgvContactList);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My PhoneBook System v1.7";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ctxMinimize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.NotifyIcon ntfyMinimize;
        private System.Windows.Forms.ContextMenuStrip ctxMinimize;
        private System.Windows.Forms.ToolStripMenuItem ctxReturn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctxTimeSinceReboot;
        private System.Windows.Forms.ToolStripMenuItem ctxCurrentOSVersion;
        private System.Windows.Forms.ToolStripMenuItem ctxFrameworkVersion;
        private System.Windows.Forms.ToolStripMenuItem ctxCurrentTimeZone;
        private System.Windows.Forms.ToolStripMenuItem ctxCurrentDate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.ToolStripMenuItem mItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mItemContactList;
        private System.Windows.Forms.ToolStripMenuItem mItemNew;
        private System.Windows.Forms.ToolStripMenuItem mItemEdit;
        private System.Windows.Forms.ToolStripMenuItem mItemErase;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mItemExit;
        private System.Windows.Forms.ToolStripMenuItem mItemPw;
        private System.Windows.Forms.ToolStripMenuItem mItemProtect;
        private System.Windows.Forms.ToolStripMenuItem mItemChangePw;
        private System.Windows.Forms.ToolStripMenuItem mItemSearch;
    }
}

