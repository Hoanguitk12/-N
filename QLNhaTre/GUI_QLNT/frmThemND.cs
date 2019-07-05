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
        private void ThemUsers(string taiKhoan, int maGV, string quyen)
        {
            if (NguoiDungBUS.Instance.ThemUsers(taiKhoan, maGV, quyen))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool CheckData()
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
               
                MessageBox.Show("Bạn chưa nhập tên đăng nhập","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return false;
            }
            
            if (NguoiDungBUS.Instance.Check(txtTaiKhoan.Text))
            {
                MessageBox.Show("trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (CheckData())
            {
                string taiKhoan = txtTaiKhoan.Text;
               
                int maGV = (cbGiaoVien.SelectedItem as DTO_QLNT.GiaoVien).MaGiaoVien;
                string quyen = cbQuyen.SelectedItem.ToString();
                ThemUsers(taiKhoan, maGV,quyen);
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

       

        private void frmThemND_Load(object sender, EventArgs e)
        {
            LoadTenGvtoCombobox();
            cbQuyen.SelectedIndex = 0;
        }
    }
}
