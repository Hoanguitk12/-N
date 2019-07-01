using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class frmThemHS : Form
    {
        public frmThemHS()
        {
            InitializeComponent();
        }

        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            cbNamHoc.ValueMember = "MANAMHOC";
        }

        private void LoadLoptoCombobox()
        {
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((cbNamHoc.SelectedItem as NamHoc).MaNamHoc);
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemHS_Load(object sender, EventArgs e)
        {
            LoadNamHoctoCombobox();

            /* var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
             Top = _point.Y;
             Left = _point.X - Width;*/
        }

        private string GetGioiTinh()
        {
            if (rbtnNam.Checked)
                return rbtnNam.Text;
            else
                return rbtnNu.Text;
        }
        bool kq;
        private void ThemHocSinh(string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            
            try
            {
               kq = HocSinhBUS.Instance.ThemHocSinh(ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            }
            catch (SqlException sqlex)
            {

                if (sqlex.Procedure == "SiSoToiDa" || sqlex.Message.Contains("lop full"))
                {
                    MessageBox.Show("Đã đạt tối đa học sinh trong lớp này");
                }
                else
                    MessageBox.Show("Có lỗi!");
            }
            
            finally
            {
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!");
                }
            }
            
        }
        bool CheckData()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;

            }

            if (dtpkNgaySinh.Value.Year - 2019 > 100 || dtpkNgaySinh.Value.Year - 2019 < 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpkNgaySinh.Focus();
                return false;
            }
            if (dtpkNgayVaoHoc.Value.Day - DateTime.Now.Day <= 0)
            {
                MessageBox.Show("Ngày vào học không hợp lệ");
                dtpkNgayVaoHoc.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtHoTenCha.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTenCha.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtSDTCha.Text))
            {
                MessageBox.Show("Bạn chưa nhập sdt cha", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDTCha.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtHoTenMe.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txtHoTenMe.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtSDTMe.Text))
            {
                MessageBox.Show("Bạn chưa nhập sdt mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDTMe.Focus();
                return false;

            }
            return true;

            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string hoten = txtHoTen.Text;
                string gioitinh = GetGioiTinh();
                string ngaysinh = dtpkNgaySinh.Value.ToString("MM/dd/yyyy");
                int malop = (cbLop.SelectedItem as Lop).MaLop;
                string ngayvaohoc = dtpkNgayVaoHoc.Value.Date.ToString("MM/dd/yyyy");
                string diachi = txtDiaChi.Text;
                string tencha = txtHoTenCha.Text;
                string sdtcha = txtSDTCha.Text;
                string tenme = txtHoTenMe.Text;
                string sdtme = txtSDTMe.Text;
                ThemHocSinh(hoten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            }
            else
                this.Dispose();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        

    }
}