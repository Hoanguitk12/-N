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
        
        public frmSuaND(UsersDTO gv)
        {
            InitializeComponent();
            Id = gv.Id;
          
            textBox1.Text = gv.TaiKhoan;
            textBox2.Text = gv.MatKhau;
          //  textBox3.Text = gv.Ten;

        }
        private void SuaUsers(int id, string taiKhoan, string matKhau, int maGV, string quyen)
        {
            if (UsersBUS.Instance.SuaUsers(id, taiKhoan, matKhau, maGV, quyen))
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
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }

            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string taiKhoan = textBox1.Text;


                string matKhau = textBox2.Text;
                string ten = textBox3.Text;
                string quyen = "Người dùng";//mac định thêm dô là người dùng
                // tui để mặc định mã gv = 2 á , còn ông muốn để giá trị khác thì còn cái textbox tên t chưa xài á cũng chưa đổi tên lun :v
                SuaUsers(Id, taiKhoan, matKhau, 2, quyen);

                this.Dispose();
            }
            else this.Dispose();
        }
    }
}
