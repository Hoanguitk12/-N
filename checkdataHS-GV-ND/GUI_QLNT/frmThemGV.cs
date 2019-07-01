using BUS_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class frmThemGV : Form
    {
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string GetGioiTinh()
        {
            if (rbtnNam.Checked == true)
            {
                return rbtnNam.Text;
            }
            else
            {
                return rbtnNu.Text;
            }

        }
        private void ThemGiaoVien(string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tongiao)
        {
            if (GiaoVienBUS.Instance.ThemGiaoVien(hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tongiao))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }
       bool CheckData()
        {
            if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;

            }
            if(string.IsNullOrEmpty(txtDanToc.Text))
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;

            }
            if(string.IsNullOrEmpty(txtTonGiao.Text))
            {
                MessageBox.Show("Bạn chưa nhập tôn giáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập sdt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTrinhDo.Text))
            {
                MessageBox.Show("Bạn chưa nhập trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(GetGioiTinh()))
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if(dtpkNgaySinh.Value.Year-2019>100|| dtpkNgaySinh.Value.Year - 2019<0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpkNgaySinh.Focus();
                return false;
            }
            if(dtpkNgayVaoLam.Value.Day-DateTime.Now.Day<=0)
            {
                MessageBox.Show("Ngày vào làm không hợp lệ");
            }
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string hoTen = txtHoTen.Text;
                string gioitinh = GetGioiTinh();
                string ngaysinh = dtpkNgaySinh.Value.Date.ToString("MM/dd/yyyy");
                string dantoc = txtDanToc.Text;
                string tongiao = txtTonGiao.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string ngayvaolam = dtpkNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
                string trinhdo = txtTrinhDo.Text;
                ThemGiaoVien(hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, tongiao);
                this.Dispose();
            }
            else this.Dispose();
        
        }
    }
}
