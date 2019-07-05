namespace GUI_QLNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnDMK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnDMK);
            this.panel1.Controls.Add(this.pnlSide);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnHeThong);
            this.panel1.Controls.Add(this.btnGiaoVien);
            this.panel1.Controls.Add(this.btnHocSinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 560);
            this.panel1.TabIndex = 0;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.Gray;
            this.pnlSide.Location = new System.Drawing.Point(0, 15);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(8, 70);
            this.pnlSide.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(0, 225);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(158, 70);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "    Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.Transparent;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHeThong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnHeThong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.Location = new System.Drawing.Point(0, 155);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(158, 70);
            this.btnHeThong.TabIndex = 3;
            this.btnHeThong.Text = "    Danh mục";
            this.btnHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHeThong.UseVisualStyleBackColor = false;
            this.btnHeThong.Click += new System.EventHandler(this.btnHeThong_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.btnGiaoVien.FlatAppearance.BorderSize = 0;
            this.btnGiaoVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGiaoVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnGiaoVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 85);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(158, 70);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "    Giáo viên";
            this.btnGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.btnHocSinh.FlatAppearance.BorderSize = 0;
            this.btnHocSinh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHocSinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnHocSinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocSinh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Image")));
            this.btnHocSinh.Location = new System.Drawing.Point(0, 15);
            this.btnHocSinh.Margin = new System.Windows.Forms.Padding(0);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(158, 70);
            this.btnHocSinh.TabIndex = 0;
            this.btnHocSinh.Text = "    Học sinh";
            this.btnHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 15);
            this.panel2.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(178, 75);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(882, 545);
            this.pnlControl.TabIndex = 2;
            // 
            // btnDMK
            // 
            this.btnDMK.BackColor = System.Drawing.Color.Transparent;
            this.btnDMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDMK.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDMK.FlatAppearance.BorderSize = 0;
            this.btnDMK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnDMK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnDMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMK.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDMK.Image")));
            this.btnDMK.Location = new System.Drawing.Point(-2, 535);
            this.btnDMK.Margin = new System.Windows.Forms.Padding(0);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(25, 25);
            this.btnDMK.TabIndex = 4;
            this.btnDMK.UseVisualStyleBackColor = false;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "QUẢN LÝ NHÀ TRẺ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnDMK;
    }
}