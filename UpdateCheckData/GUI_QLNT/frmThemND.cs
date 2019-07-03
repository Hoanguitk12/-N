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
    public partial class frmThemND : Form
    {
        public frmThemND()
        {
            InitializeComponent();
          
        }
        private void ThemUsers(string taiKhoan, string matKhau, int maGV, string quyen)
        {
            if (NguoiDungBUS.Instance.ThemUsers(taiKhoan, matKhau, maGV, quyen))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }
        bool CheckData()
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
               
                MessageBox.Show("Bạn chưa nhập tên đăng nhập","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return false;
            }
            if (NguoiDungBUS.Instance.Check(txtTaiKhoan.Text))
            {
                MessageBox.Show("trùng");
                return false;
            }


            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (CheckData())
            {
                string taiKhoan = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                int maGV = (cbGiaoVien.SelectedItem as DTO_QLNT.GiaoVien).MaGiaoVien;
                string quyen = cbQuyen.SelectedItem.ToString();
                ThemUsers(taiKhoan, matKhau, maGV,quyen);
                this.Dispose();
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadTenGvtoCombobox()
        {
            
            cbGiaoVien.DisplayMember = "HOTEN";
            cbGiaoVien.ValueMember = "MAGV";
            cbGiaoVien.DataSource = GiaoVienBUS.Instance.GetListGiaoVien();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmThemND_Load(object sender, EventArgs e)
        {
            LoadTenGvtoCombobox();
            cbQuyen.SelectedIndex = 0;
        }
    }
}
