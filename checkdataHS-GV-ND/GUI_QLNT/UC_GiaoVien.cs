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
    public partial class UC_GiaoVien : UserControl
    {
        public UC_GiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGV fthemgv = new frmThemGV();
            fthemgv.ShowDialog();
            LoadDSGVtodtgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridDSGV.SelectedRows.Count > 0)
            {
                int maGV = (int)gridDSGV.Rows[gridDSGV.SelectedRows[0].Index].Cells[1].Value;
                GiaoVien gv = GiaoVienBUS.Instance.GetGiaoVienByMaGV(maGV);
                frmSuaGV fsua = new frmSuaGV(gv);
                fsua.ShowDialog();
                LoadDSGVtodtgv();
            }
            else
            {
                MessageBox.Show("Hãy chọn học sinh muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?.", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int maGV;
                maGV = (int)gridDSGV.Rows[gridDSGV.SelectedRows[0].Index].Cells[1].Value;
                if (GiaoVienBUS.Instance.XoaGiaoVien(maGV))
                {
                    MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSGVtodtgv();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_GiaoVien_Load(object sender, EventArgs e)
        {
            LoadDSGVtodtgv();
            LoadNamHoctoCombobox();
            
        }

        private void LoadDSGVtodtgv()
        {
            gridDSGV.DataSource = GiaoVienBUS.Instance.GetGiaoVien();

            gridDSGV.Columns[0].Visible = true;
            gridDSGV.Columns[1].Visible = false;//ẩn cột mã ;
            gridDSGV.Columns[2].HeaderText = "Họ tên";
            gridDSGV.Columns[3].HeaderText = "Giới tính";
            gridDSGV.Columns[4].HeaderText = "Ngày sinh";
            gridDSGV.Columns[5].HeaderText = "Dân tộc";
            gridDSGV.Columns[6].HeaderText = "Tôn Giáo";
            gridDSGV.Columns[7].HeaderText = "Địa chỉ";
            gridDSGV.Columns[8].HeaderText = "SDT";
            gridDSGV.Columns[9].HeaderText = "Trình Độ";
            gridDSGV.Columns[10].HeaderText = "Ngày Vào Làm";
            gridDSGV.Columns[11].Visible = false;
            
            gridDSGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridDSGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }



        
        private void LoadGVTodgvPhanCong()
        {
            string query = "SELECT MAGV, HOTEN, GIAOVIEN.MALOP, LOP.TENLOP FROM GIAOVIEN left join LOP on GIAOVIEN.MALOP=LOP.MALOP ORDER BY HOTEN";

             
            dgvPhanCong.DataSource = GiaoVienBUS.Instance.GetGiaoVien(query);

            dgvPhanCong.Columns[0].Visible = true;
            dgvPhanCong.Columns[1].Visible = false;//ẩn cột mã ;
            dgvPhanCong.Columns[2].HeaderText = "Họ tên";
            dgvPhanCong.Columns[3].Visible = false;
            dgvPhanCong.Columns[4].HeaderText = "Lớp hiện tại";
            dgvPhanCong.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPhanCong.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

         

        private void gridDSGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gridDSGV.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvPhanCong_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvPhanCong.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void tabctrlGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlGV.SelectedTab == tabDSGV)
            {
                label2.Hide();
                cbNamHoc.Hide();
                btnThem.Show();
                btnXoa.Show();
                btnSua.Show();
            }
            else
            {
                label2.Show();
                cbNamHoc.Show();
                btnXoa.Hide();
                btnThem.Hide();
                btnSua.Hide();
                LoadGVTodgvPhanCong();
            }
        }

        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            //cbNamHoc.ValueMember = "MANAMHOC";
        }

        private void LoadLoptoCombobox()
        {

            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((cbNamHoc.SelectedItem as NamHoc).MaNamHoc);
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.SelectedItem = null;
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGV.Text = dgvPhanCong.Rows[dgvPhanCong.SelectedRows[0].Index].Cells[2].Value.ToString();
            string malop = dgvPhanCong.Rows[dgvPhanCong.SelectedRows[0].Index].Cells[3].Value.ToString();
            if (malop != "")
            {
                cbLop.SelectedValue = Convert.ToInt32(malop);
            }
            else
                cbLop.SelectedItem = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbLop.SelectedItem != null)
            {
                int magv = (int)dgvPhanCong.Rows[dgvPhanCong.SelectedRows[0].Index].Cells[1].Value;
                int malop = (int)cbLop.SelectedValue;
                if (GiaoVienBUS.Instance.PhanCongGiaoVien(magv, malop))
                {
                    MessageBox.Show("Đã phân công!");
                }
                else MessageBox.Show("Thất bại!");

            }
            else
                MessageBox.Show("Chọn một lớp để phân công!!");
            
        }
    }
}
