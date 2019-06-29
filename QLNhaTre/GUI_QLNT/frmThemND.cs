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
        private void  ThemUsers(string taiKhoan, string matKhau, string ten, string quyen)
        {
            if (UsersBUS.Instance.ThemUsers(taiKhoan,matKhau,ten,quyen))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox1.Text;
            string matKhau = textBox2.Text;
            string ten = textBox3.Text;
           
            ThemUsers(taiKhoan, matKhau, ten, "Nguoi Dung");
            this.Dispose();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
