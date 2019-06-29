using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class frmSuaHS : Form
    {
        public frmSuaHS()
        {
            InitializeComponent();
        }
        private int mahs;

        public frmSuaHS(HocSinh hs, int manamhoc)
        {
            
            InitializeComponent();
            mahs = hs.MaHS;
            txtHoTen.Text = hs.HoTen;

            if (hs.GioiTinh == "Nam")
                rbtnNam.Checked = true;
            else rbtnNu.Checked = true;

            dtpkNgaySinh.Value = hs.NgaySinh;

            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            cbNamHoc.ValueMember = "MANAMHOC";
            cbNamHoc.SelectedValue = manamhoc;

            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc(manamhoc);
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
            cbLop.SelectedValue = hs.MaLop;

            dtpkNgayVaoHoc.Value = hs.NgayVaoHoc;

            txtDiaChi.Text = hs.DiaChi;
            txtHoTenCha.Text = hs.HoTenCha;
            txtSDTCha.Text = hs.SdtCha;
            txtHoTenMe.Text = hs.HoTenMe;
            txtSDTMe.Text = hs.SdtMe;
        }

        private void SuaHocSinh(int mahs,string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            if (HocSinhBUS.Instance.SuaHocSinh(mahs, ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme))
            {
                MessageBox.Show("Cập nhật học sinh thành công!");
            }
            else
                MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string hoten = txtHoTen.Text.Trim();
            string gioitinh;
            if (rbtnNam.Checked)
                gioitinh = rbtnNam.Text.Trim();
            else gioitinh = rbtnNu.Text.Trim();
            string ngaysinh = dtpkNgaySinh.Value.ToString("MM/dd/yyyy");

            int malop = (cbLop.SelectedItem as Lop).MaLop;
            string ngayvaohoc = dtpkNgayVaoHoc.Value.ToString("MM/dd/yyyy");
            string diachi = txtDiaChi.Text.Trim();
            string tencha = txtHoTenCha.Text.Trim();
            string sdtcha = txtSDTCha.Text.Trim();
            string tenme = txtHoTenMe.Text.Trim();
            string sdtme = txtSDTMe.Text.Trim();
            SuaHocSinh(mahs, hoten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            
            this.Dispose();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }

        private void LoadLoptoCombobox()
        {

            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((cbNamHoc.SelectedItem as NamHoc).MaNamHoc);
            cbLop.DisplayMember = "TENLOP";
            //cbLop.ValueMember = "MALOP";
        }
    }
}
