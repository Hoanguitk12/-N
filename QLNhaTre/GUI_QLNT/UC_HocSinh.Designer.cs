namespace GUI_QLNT
{
    partial class UC_HocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HocSinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabctrlHocsinh = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDSHS = new System.Windows.Forms.TabPage();
            this.dgvDSHS = new System.Windows.Forms.DataGridView();
            this.clstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSK = new System.Windows.Forms.TabPage();
            this.dgvSK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.cbThangdo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tabctrlHocsinh.SuspendLayout();
            this.tabDSHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).BeginInit();
            this.tabSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 452);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 5);
            this.panel2.TabIndex = 3;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabctrlHocsinh;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(5, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(892, 23);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "`";
            // 
            // tabctrlHocsinh
            // 
            this.tabctrlHocsinh.Controls.Add(this.tabDSHS);
            this.tabctrlHocsinh.Controls.Add(this.tabSK);
            this.tabctrlHocsinh.Depth = 0;
            this.tabctrlHocsinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlHocsinh.Location = new System.Drawing.Point(5, 68);
            this.tabctrlHocsinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabctrlHocsinh.Name = "tabctrlHocsinh";
            this.tabctrlHocsinh.SelectedIndex = 0;
            this.tabctrlHocsinh.Size = new System.Drawing.Size(892, 384);
            this.tabctrlHocsinh.TabIndex = 8;
            this.tabctrlHocsinh.SelectedIndexChanged += new System.EventHandler(this.tabctrlHocsinh_SelectedIndexChanged);
            // 
            // tabDSHS
            // 
            this.tabDSHS.Controls.Add(this.dgvDSHS);
            this.tabDSHS.Location = new System.Drawing.Point(4, 22);
            this.tabDSHS.Name = "tabDSHS";
            this.tabDSHS.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSHS.Size = new System.Drawing.Size(884, 358);
            this.tabDSHS.TabIndex = 0;
            this.tabDSHS.Text = "Danh sách học sinh";
            this.tabDSHS.UseVisualStyleBackColor = true;
            // 
            // dgvDSHS
            // 
            this.dgvDSHS.AllowUserToAddRows = false;
            this.dgvDSHS.AllowUserToDeleteRows = false;
            this.dgvDSHS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDSHS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDSHS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSHS.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSHS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clstt});
            this.dgvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHS.EnableHeadersVisualStyles = false;
            this.dgvDSHS.Location = new System.Drawing.Point(3, 3);
            this.dgvDSHS.Name = "dgvDSHS";
            this.dgvDSHS.ReadOnly = true;
            this.dgvDSHS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDSHS.RowHeadersVisible = false;
            this.dgvDSHS.RowHeadersWidth = 20;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvDSHS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSHS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHS.Size = new System.Drawing.Size(878, 352);
            this.dgvDSHS.TabIndex = 0;
            this.dgvDSHS.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDSHS_RowPostPaint);
            // 
            // clstt
            // 
            this.clstt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clstt.HeaderText = "STT";
            this.clstt.Name = "clstt";
            this.clstt.ReadOnly = true;
            this.clstt.Visible = false;
            // 
            // tabSK
            // 
            this.tabSK.Controls.Add(this.dgvSK);
            this.tabSK.Location = new System.Drawing.Point(4, 22);
            this.tabSK.Name = "tabSK";
            this.tabSK.Padding = new System.Windows.Forms.Padding(3);
            this.tabSK.Size = new System.Drawing.Size(884, 358);
            this.tabSK.TabIndex = 1;
            this.tabSK.Text = "Theo dõi sức khỏe";
            this.tabSK.UseVisualStyleBackColor = true;
            // 
            // dgvSK
            // 
            this.dgvSK.AllowUserToAddRows = false;
            this.dgvSK.AllowUserToDeleteRows = false;
            this.dgvSK.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvSK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSK.BackgroundColor = System.Drawing.Color.White;
            this.dgvSK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSK.EnableHeadersVisualStyles = false;
            this.dgvSK.Location = new System.Drawing.Point(3, 3);
            this.dgvSK.Name = "dgvSK";
            this.dgvSK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSK.RowHeadersVisible = false;
            this.dgvSK.RowHeadersWidth = 20;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSK.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSK.Size = new System.Drawing.Size(878, 352);
            this.dgvSK.TabIndex = 1;
            this.dgvSK.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSK_EditingControlShowing);
            this.dgvSK.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSK_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 33;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTool.Controls.Add(this.cbThangdo);
            this.pnlTool.Controls.Add(this.label3);
            this.pnlTool.Controls.Add(this.cbNamHoc);
            this.pnlTool.Controls.Add(this.label2);
            this.pnlTool.Controls.Add(this.cbLop);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.btnThem);
            this.pnlTool.Controls.Add(this.btnBaoCao);
            this.pnlTool.Controls.Add(this.btnLuu);
            this.pnlTool.Controls.Add(this.btnXoa);
            this.pnlTool.Controls.Add(this.btnSua);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(5, 28);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(892, 40);
            this.pnlTool.TabIndex = 7;
            // 
            // cbThangdo
            // 
            this.cbThangdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThangdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbThangdo.FormattingEnabled = true;
            this.cbThangdo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThangdo.Location = new System.Drawing.Point(395, 11);
            this.cbThangdo.Name = "cbThangdo";
            this.cbThangdo.Size = new System.Drawing.Size(40, 21);
            this.cbThangdo.TabIndex = 2;
            this.cbThangdo.Visible = false;
            this.cbThangdo.SelectedIndexChanged += new System.EventHandler(this.cbThangdo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tháng:";
            this.label3.Visible = false;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(85, 10);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(96, 21);
            this.cbNamHoc.TabIndex = 2;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm học:";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(231, 10);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(96, 21);
            this.cbLop.TabIndex = 2;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp:";
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
            this.btnThem.Location = new System.Drawing.Point(547, 1);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = " Thêm mới";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.Location = new System.Drawing.Point(661, 1);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(114, 39);
            this.btnBaoCao.TabIndex = 0;
            this.btnBaoCao.Text = " Xuất báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Visible = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(778, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 40);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(778, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(661, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 39);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = " Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // UC_HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabctrlHocsinh);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_HocSinh";
            this.Size = new System.Drawing.Size(897, 452);
            this.Load += new System.EventHandler(this.UC_HocSinh_Load);
            this.tabctrlHocsinh.ResumeLayout(false);
            this.tabDSHS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHS)).EndInit();
            this.tabSK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSK)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabctrlHocsinh;
        private System.Windows.Forms.TabPage tabDSHS;
        private System.Windows.Forms.TabPage tabSK;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvDSHS;
        private System.Windows.Forms.ComboBox cbThangdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSK;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
