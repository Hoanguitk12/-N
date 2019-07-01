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
            if (UsersBUS.Instance.ThemUsers(taiKhoan, matKhau, maGV, quyen))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }
        bool CheckData()
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
               
                MessageBox.Show("Bạn chưa nhập tên đăng nhập","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (CheckData())
            {


                string taiKhoan = textBox1.Text;



                string matKhau = textBox2.Text;
               int maGV = (comboBox1.SelectedItem as DTO_QLNT.GiaoVien).MaGiaoVien;

                ThemUsers(taiKhoan, matKhau, maGV, "giáo viên");
                this.Dispose();


            }
            else
                this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadTenGvtoCombobox()
        {
            
            comboBox1.DisplayMember = "HOTEN";
          comboBox1.ValueMember = "MAGV";
            comboBox1.DataSource = GiaoVienBUS.Instance.GetListGiaoVien();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmThemND_Load(object sender, EventArgs e)
        {
            LoadTenGvtoCombobox();
        }
    }
}
