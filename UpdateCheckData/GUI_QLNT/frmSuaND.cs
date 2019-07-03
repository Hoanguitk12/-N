using BUS_QLNT;
using DTO_QLNT;
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
    public partial class frmSuaND : Form
    {
        public frmSuaND()
        {
            InitializeComponent();
        }
        int Id;
        
        public frmSuaND(NguoiDung gv)
        {
            InitializeComponent();
            Id = gv.Id;
           // comboBox1.DataSource = GiaoVienBUS.Instance.GetListGiaoVien();
            cbGiaoVien.DisplayMember = "HOTEN";
            cbGiaoVien.ValueMember = "MAGV";
            cbGiaoVien.DataSource = GiaoVienBUS.Instance.GetListGiaoVien();
            cbGiaoVien.SelectedValue = gv.MaGV;
          
            txtTaiKhoan.Text = gv.TaiKhoan;
            txtMatKhau.Text = gv.MatKhau;
          //  textBox3.Text = gv.Ten;

        }
        private void SuaUsers(int id, string taiKhoan, string matKhau, int maGV, string quyen)
        {
            if (NguoiDungBUS.Instance.SuaUsers(id, taiKhoan, matKhau, maGV, quyen))
            {
                MessageBox.Show("Sửa Thành Công");
            }
            else
                MessageBox.Show("Sửa Thất Bại");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        bool CheckData()
        {
            
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {

                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         
            if (CheckData())
            {
                string taiKhoan = txtTaiKhoan.Text;


                string matKhau = txtMatKhau.Text;
                int maGV = (cbGiaoVien.SelectedItem as DTO_QLNT.GiaoVien).MaGiaoVien;

                string quyen = "giáo viên";//mac định thêm dô là người dùng
                // tui để mặc định mã gv = 2 á , còn ông muốn để giá trị khác thì còn cái textbox tên t chưa xài á cũng chưa đổi tên lun :v
                SuaUsers(Id, taiKhoan, matKhau, maGV, quyen);

                this.Dispose();
            }
            else this.Dispose();
        }
        private void LoadTenGvtoCombobox()
        {
            cbGiaoVien.DataSource = GiaoVienBUS.Instance.GetListGiaoVien();
            cbGiaoVien.DisplayMember = "HOTEN";
           //comboBox1.ValueMember = "MAGV";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
