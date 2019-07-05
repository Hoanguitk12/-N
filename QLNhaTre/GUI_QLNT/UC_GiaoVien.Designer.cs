namespace GUI_QLNT
{
    partial class UC_GiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GiaoVien));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabctrlGV = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDSGV = new System.Windows.Forms.TabPage();
            this.gridDSGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPhanCong = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tabctrlGV.SuspendLayout();
            this.tabDSGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSGV)).BeginInit();
            this.tabPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 5);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 439);
            this.panel1.TabIndex = 4;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabctrlGV;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(5, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(686, 23);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "`";
            // 
            // tabctrlGV
            // 
            this.tabctrlGV.Controls.Add(this.tabDSGV);
            this.tabctrlGV.Controls.Add(this.tabPhanCong);
            this.tabctrlGV.Depth = 0;
            this.tabctrlGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlGV.Location = new System.Drawing.Point(5, 68);
            this.tabctrlGV.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlGV.Name = "tabctrlGV";
            this.tabctrlGV.SelectedIndex = 0;
            this.tabctrlGV.Size = new System.Drawing.Size(686, 371);
            this.tabctrlGV.TabIndex = 9;
            this.tabctrlGV.SelectedIndexChanged += new System.EventHandler(this.tabctrlGV_SelectedIndexChanged);
            // 
            // tabDSGV
            // 
            this.tabDSGV.Controls.Add(this.gridDSGV);
            this.tabDSGV.Location = new System.Drawing.Point(4, 22);
            this.tabDSGV.Name = "tabDSGV";
            this.tabDSGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSGV.Size = new System.Drawing.Size(678, 345);
            this.tabDSGV.TabIndex = 0;
            this.tabDSGV.Text = "Danh sách giáo viên";
            this.tabDSGV.UseVisualStyleBackColor = true;
            // 
            // gridDSGV
            // 
            this.gridDSGV.AllowUserToAddRows = false;
            this.gridDSGV.AllowUserToDeleteRows = false;
            this.gridDSGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.gridDSGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDSGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridDSGV.BackgroundColor = System.Drawing.Color.White;
            this.gridDSGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDSGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDSGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gridDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSGV.EnableHeadersVisualStyles = false;
            this.gridDSGV.Location = new System.Drawing.Point(3, 3);
            this.gridDSGV.Name = "gridDSGV";
            this.gridDSGV.ReadOnly = true;
            this.gridDSGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridDSGV.RowHeadersVisible = false;
            this.gridDSGV.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridDSGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDSGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSGV.Size = new System.Drawing.Size(672, 339);
            this.gridDSGV.TabIndex = 2;
            this.gridDSGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridDSGV_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 33;
            // 
            // tabPhanCong
            // 
            this.tabPhanCong.Controls.Add(this.btnLuu);
            this.tabPhanCong.Controls.Add(this.cbLop);
            this.tabPhanCong.Controls.Add(this.txtTenGV);
            this.tabPhanCong.Controls.Add(this.label3);
            this.tabPhanCong.Controls.Add(this.label1);
            this.tabPhanCong.Controls.Add(this.dgvPhanCong);
            this.tabPhanCong.Location = new System.Drawing.Point(4, 22);
            this.tabPhanCong.Name = "tabPhanCong";
            this.tabPhanCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhanCong.Size = new System.Drawing.Size(678, 345);
            this.tabPhanCong.TabIndex = 1;
            this.tabPhanCong.Text = "Phân công giảng dạy";
            this.tabPhanCong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Location = new System.Drawing.Point(577, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 21);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(435, 5);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 6;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Location = new System.Drawing.Point(81, 5);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(251, 20);
            this.txtTenGV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phụ trách lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giáo viên:";
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToDeleteRows = false;
            this.dgvPhanCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhanCong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvPhanCong.EnableHeadersVisualStyles = false;
            this.dgvPhanCong.Location = new System.Drawing.Point(3, 32);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.ReadOnly = true;
            this.dgvPhanCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPhanCong.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(672, 310);
            this.dgvPhanCong.TabIndex = 3;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            this.dgvPhanCong.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPhanCong_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 34;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTool.Controls.Add(this.cbNamHoc);
            this.pnlTool.Controls.Add(this.btnSua);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.btnThem);
            this.pnlTool.Controls.Add(this.btnXoa);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(5, 28);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(686, 40);
            this.pnlTool.TabIndex = 8;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(85, 9);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(96, 21);
            this.cbNamHoc.TabIndex = 5;
            this.cbNamHoc.Visible = false;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(455, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 39);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = " Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm học:";
            this.label2.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(341, 1);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = " Thêm mới";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(572, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UC_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlGV);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_GiaoVien";
            this.Size = new System.Drawing.Size(691, 439);
            this.Load += new System.EventHandler(this.UC_GiaoVien_Load);
            this.tabctrlGV.ResumeLayout(false);
            this.tabDSGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSGV)).EndInit();
            this.tabPhanCong.ResumeLayout(false);
            this.tabPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private MaterialSkin.Controls.MaterialTabControl tabctrlGV;
        private System.Windows.Forms.TabPage tabDSGV;
        private System.Windows.Forms.DataGridView gridDSGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage tabPhanCong;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
    }
}
