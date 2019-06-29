namespace GUI_QLNT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtMatkhau = new MetroFramework.Controls.MetroTextBox();
            this.txtTaikhoan = new MetroFramework.Controls.MetroTextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatkhau
            // 
            // 
            // 
            // 
            this.txtMatkhau.CustomButton.Image = null;
            this.txtMatkhau.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtMatkhau.CustomButton.Name = "";
            this.txtMatkhau.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMatkhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatkhau.CustomButton.TabIndex = 1;
            this.txtMatkhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatkhau.CustomButton.UseSelectable = true;
            this.txtMatkhau.CustomButton.Visible = false;
            this.txtMatkhau.DisplayIcon = true;
            this.txtMatkhau.Icon = ((System.Drawing.Image)(resources.GetObject("txtMatkhau.Icon")));
            this.txtMatkhau.Lines = new string[0];
            this.txtMatkhau.Location = new System.Drawing.Point(23, 92);
            this.txtMatkhau.MaxLength = 32767;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '●';
            this.txtMatkhau.PromptText = "Nhập mật khẩu";
            this.txtMatkhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.SelectionLength = 0;
            this.txtMatkhau.SelectionStart = 0;
            this.txtMatkhau.ShortcutsEnabled = true;
            this.txtMatkhau.Size = new System.Drawing.Size(196, 23);
            this.txtMatkhau.TabIndex = 0;
            this.txtMatkhau.UseSelectable = true;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.WaterMark = "Nhập mật khẩu";
            this.txtMatkhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatkhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTaikhoan
            // 
            // 
            // 
            // 
            this.txtTaikhoan.CustomButton.Image = null;
            this.txtTaikhoan.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.txtTaikhoan.CustomButton.Name = "";
            this.txtTaikhoan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTaikhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaikhoan.CustomButton.TabIndex = 1;
            this.txtTaikhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaikhoan.CustomButton.UseSelectable = true;
            this.txtTaikhoan.CustomButton.Visible = false;
            this.txtTaikhoan.DisplayIcon = true;
            this.txtTaikhoan.Icon = ((System.Drawing.Image)(resources.GetObject("txtTaikhoan.Icon")));
            this.txtTaikhoan.Lines = new string[0];
            this.txtTaikhoan.Location = new System.Drawing.Point(23, 63);
            this.txtTaikhoan.MaxLength = 32767;
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PasswordChar = '\0';
            this.txtTaikhoan.PromptText = "Nhập tên tài khoản";
            this.txtTaikhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.SelectionLength = 0;
            this.txtTaikhoan.SelectionStart = 0;
            this.txtTaikhoan.ShortcutsEnabled = true;
            this.txtTaikhoan.Size = new System.Drawing.Size(196, 23);
            this.txtTaikhoan.TabIndex = 0;
            this.txtTaikhoan.UseSelectable = true;
            this.txtTaikhoan.WaterMark = "Nhập tên tài khoản";
            this.txtTaikhoan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaikhoan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangnhap.Location = new System.Drawing.Point(132, 121);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(87, 23);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 158);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.txtMatkhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtMatkhau;
        private MetroFramework.Controls.MetroTextBox txtTaikhoan;
        private System.Windows.Forms.Button btnDangnhap;
    }
}