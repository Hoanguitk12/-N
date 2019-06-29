using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;



namespace GUI_QLNT
{
    public partial class UC_HocSinh : UserControl
    {
        public UC_HocSinh()
        {
            InitializeComponent();
        }

        #region event

        private void UC_HocSinh_Load(object sender, EventArgs e)
        {
            LoadNamHoctoCombobox();
            
        }

        private void dgvDSHS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)// auto đánh stt
        {
            dgvDSHS.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }


        private void tabctrlHocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabDSHS)
            {
                btnLuu.Hide();
                label3.Hide();
                cbThangdo.Hide();
                button1.Hide();
                btnThem.Show();
                btnSua.Show();
                btnXoa.Show();
            }
            else
            {
                
                btnLuu.Show();
                label3.Show();
                cbThangdo.Show();
                cbThangdo.SelectedItem = DateTime.Now.Month.ToString();
                button1.Show();
                btnThem.Hide();
                btnSua.Hide();
                btnXoa.Hide();
            }
        }


        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSHocSinhtodtgv();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHS fthem = new frmThemHS();
            fthem.ShowDialog();
            LoadDSHocSinhtodtgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHS.SelectedRows.Count != 0)
            {
                int mahs = (int)dgvDSHS.Rows[dgvDSHS.SelectedRows[0].Index].Cells[1].Value;
                HocSinh hs = HocSinhBUS.Instance.GetHocSinhByMaHS(mahs);
                frmSuaHS fsua = new frmSuaHS(hs,(cbNamHoc.SelectedValue as NamHoc).MaNamHoc);
                fsua.ShowDialog();
                LoadDSHocSinhtodtgv();
            }
            else
            {
                MessageBox.Show("Hãy chọn học sinh muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHS.SelectedRows != null)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int mahs;
                    mahs = (int)dgvDSHS.Rows[dgvDSHS.SelectedRows[0].Index].Cells[1].Value;
                    if (HocSinhBUS.Instance.XoaHocSinh(mahs))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSHocSinhtodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn học sinh muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
        #endregion


        #region hàm

        private void LoadLoptoCombobox()
        {
            
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((cbNamHoc.SelectedItem as NamHoc).MaNamHoc);
            cbLop.DisplayMember = "TENLOP";
            //cbLop.ValueMember = "MALOP";
        }

        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            //cbNamHoc.ValueMember = "MANAMHOC";
        }

        private void LoadDSHocSinhtodtgv()
        {

            int malop = (cbLop.SelectedItem as Lop).MaLop;

            dgvDSHS.DataSource = HocSinhBUS.Instance.GetHocSinhByMaLop(malop);
            dgvDSHS.Columns[0].Visible = true;
            dgvDSHS.Columns[1].Visible = false;//ẩn cột mã học sinh;
            dgvDSHS.Columns[2].HeaderText = "Họ tên";
            dgvDSHS.Columns[3].HeaderText = "Giới tính";
            dgvDSHS.Columns[4].HeaderText = "Ngày sinh";
            dgvDSHS.Columns[5].Visible = false;//ẩn cột mã lớp
            dgvDSHS.Columns[6].HeaderText = "Ngày vào học";
            dgvDSHS.Columns[7].HeaderText = "Địa chỉ";
            dgvDSHS.Columns[8].HeaderText = "Họ tên cha";
            dgvDSHS.Columns[9].HeaderText = "Điện thoại";
            dgvDSHS.Columns[10].HeaderText = "Họ tên mẹ";
            dgvDSHS.Columns[11].HeaderText = "Điện thoại";
            dgvDSHS.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSHS.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSHS.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSHS.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }


        #endregion

        

        private void cbLop_TextChanged(object sender, EventArgs e)
        {
            LoadDSHocSinhtodtgv();
        }

        private void cbNamHoc_TextChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        private void dgvDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
