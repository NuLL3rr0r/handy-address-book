namespace PhoneBook
{
    partial class frmPw
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
            this.txtPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPw
            // 
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPw.Location = new System.Drawing.Point(0, 0);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '●';
            this.txtPw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPw.Size = new System.Drawing.Size(100, 20);
            this.txtPw.TabIndex = 1;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            // 
            // frmPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 19);
            this.Controls.Add(this.txtPw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "رمز عبور";
            this.Shown += new System.EventHandler(this.frmPw_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPw_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPw;
    }
}