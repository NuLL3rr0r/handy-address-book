namespace PhoneBook
{
    partial class frmPwChange
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
            this.txtConfirmPw = new System.Windows.Forms.TextBox();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtCurrentPw = new System.Windows.Forms.TextBox();
            this.lblConfirmPw = new System.Windows.Forms.Label();
            this.lblNewPw = new System.Windows.Forms.Label();
            this.lblCurrentPw = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfirmPw
            // 
            this.txtConfirmPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPw.Location = new System.Drawing.Point(102, 71);
            this.txtConfirmPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPw.Name = "txtConfirmPw";
            this.txtConfirmPw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConfirmPw.Size = new System.Drawing.Size(132, 21);
            this.txtConfirmPw.TabIndex = 10;
            this.txtConfirmPw.UseSystemPasswordChar = true;
            // 
            // txtNewPw
            // 
            this.txtNewPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPw.Location = new System.Drawing.Point(102, 42);
            this.txtNewPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNewPw.Size = new System.Drawing.Size(132, 21);
            this.txtNewPw.TabIndex = 9;
            this.txtNewPw.UseSystemPasswordChar = true;
            // 
            // txtCurrentPw
            // 
            this.txtCurrentPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPw.Location = new System.Drawing.Point(102, 13);
            this.txtCurrentPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentPw.Name = "txtCurrentPw";
            this.txtCurrentPw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCurrentPw.Size = new System.Drawing.Size(132, 21);
            this.txtCurrentPw.TabIndex = 8;
            this.txtCurrentPw.UseSystemPasswordChar = true;
            // 
            // lblConfirmPw
            // 
            this.lblConfirmPw.AutoSize = true;
            this.lblConfirmPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfirmPw.Location = new System.Drawing.Point(12, 73);
            this.lblConfirmPw.Name = "lblConfirmPw";
            this.lblConfirmPw.Size = new System.Drawing.Size(76, 15);
            this.lblConfirmPw.TabIndex = 15;
            this.lblConfirmPw.Text = " «∆Ìœ ﬂ·„Â ⁄»Ê—";
            // 
            // lblNewPw
            // 
            this.lblNewPw.AutoSize = true;
            this.lblNewPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewPw.Location = new System.Drawing.Point(12, 44);
            this.lblNewPw.Name = "lblNewPw";
            this.lblNewPw.Size = new System.Drawing.Size(79, 15);
            this.lblNewPw.TabIndex = 14;
            this.lblNewPw.Text = "ﬂ·„Â ⁄»Ê— ÃœÌœ";
            // 
            // lblCurrentPw
            // 
            this.lblCurrentPw.AutoSize = true;
            this.lblCurrentPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPw.Location = new System.Drawing.Point(12, 15);
            this.lblCurrentPw.Name = "lblCurrentPw";
            this.lblCurrentPw.Size = new System.Drawing.Size(83, 15);
            this.lblCurrentPw.TabIndex = 13;
            this.lblCurrentPw.Text = "ﬂ·„Â ⁄»Ê— ›⁄·Ì";
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location = new System.Drawing.Point(78, 99);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = " «∆Ìœ";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(159, 99);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "·€Ê";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // frmPwChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 132);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfirmPw);
            this.Controls.Add(this.txtNewPw);
            this.Controls.Add(this.txtCurrentPw);
            this.Controls.Add(this.lblConfirmPw);
            this.Controls.Add(this.lblNewPw);
            this.Controls.Add(this.lblCurrentPw);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPwChange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " €ÌÌ— ﬂ·„Â Ì ⁄»Ê—";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPwChange_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmPw;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtCurrentPw;
        private System.Windows.Forms.Label lblConfirmPw;
        private System.Windows.Forms.Label lblNewPw;
        private System.Windows.Forms.Label lblCurrentPw;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;

    }
}