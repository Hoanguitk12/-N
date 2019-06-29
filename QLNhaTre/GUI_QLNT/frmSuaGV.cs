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
    public partial class frmSuaGV : Form
    {
        public frmSuaGV()
        {
            InitializeComponent();
        }
       int maGV;
        public frmSuaGV(DTO_QLNT.GiaoVien gv)
        {
            InitializeComponent();
            maGV = gv.MaGiaoVien;
            textBox1.Text = gv.HoTen;
            dateTimePicker2.Value = gv.NgaySinh;
            if (gv.GioiTinh == "Nam")
               radioButton1.Checked = true;
            else radioButton2.Checked = true;
            textBox2.Text = gv.DanToc;
            textBox3.Text = gv.TonGiao;
            textBox4.Text = gv.DiaChi;
            textBox5.Text = gv.Sdt;
            textBox6.Text = gv.TrinhDo;
            dateTimePicker1.Value = gv.NgayVaoLam;


        }


      
        private void SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, int maLop, string tonGiao)
        {
            if (GiaoVienBUS.Instance.SuaGiaoVien(maGiaoVien, hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, maLop, tonGiao))
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

            string hoTen = textBox1.Text;
            string gioitinh ;
            if (radioButton1.Checked == true)
            {
                gioitinh = radioButton1.Text.Trim();

            }
            else
                gioitinh = radioButton2.Text.Trim();
            string ngaysinh = dateTimePicker2.Value.Date.ToString("MM/dd/yyyy");
            string dantoc = textBox2.Text;
            string tongiao = textBox3.Text;
            string diachi = textBox4.Text;
            string sdt = textBox5.Text;
            string ngayvaolam = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
            string trinhdo = textBox6.Text;
            SuaGiaoVien(maGV, hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, 1, tongiao);
            this.Dispose();
        }
    }
}
