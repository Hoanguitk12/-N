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
        int maGV;
        public frmSuaND(UsersDTO gv)
        {
            InitializeComponent();
            Id = gv.Id;
            maGV = gv.MaGV;
            textBox1.Text = gv.TaiKhoan;
            textBox2.Text = gv.MatKhau;
            textBox3.Text = gv.Ten;
            
        }
        private void SuaUsers(int id, string taiKhoan, string matKhau, string ten, string quyen)
        {
            if (UsersBUS.Instance.SuaUsers(id,taiKhoan,matKhau,ten,quyen))
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox1.Text;
        
           
            string matKhau = textBox2.Text;
            string ten = textBox3.Text;
            string quyen = "NguoiDung";//mac định thêm dô là người dùng

            SuaUsers(Id, taiKhoan, matKhau, ten, quyen);
           
            this.Dispose();
        }
    }
}
