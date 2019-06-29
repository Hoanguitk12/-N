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

        private void frmThemGV_Load(object sender, EventArgs e)
        {

        }
        private string GetGioiTinh()
        {
            if (radioButton1.Checked == true)
            {
                return radioButton1.Text;
            }
            else
         
            {  return radioButton2.Text; }
            
        }
        private void ThemGiaoVien( string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tongiao)
        {
            if (GiaoVienBUS.Instance.ThemGiaoVien( hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tongiao))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm Thất bại");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;
            string gioitinh = GetGioiTinh();
            string ngaysinh = dateTimePicker2.Value.Date.ToString("MM/dd/yyyy");
            string dantoc = textBox2.Text;
            string tongiao = textBox3.Text;
            string diachi = textBox4.Text;
            string sdt = textBox5.Text;
            string ngayvaolam=dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            string trinhdo = textBox6.Text;
            ThemGiaoVien( hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, tongiao);
            this.Dispose();
        }
    }
}
