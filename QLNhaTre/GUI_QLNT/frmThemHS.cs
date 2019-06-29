using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class frmThemHS : Form
    {
        public frmThemHS()
        {
            InitializeComponent();
        }

        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NAMBDKT";
            cbNamHoc.ValueMember = "MANAMHOC";
        }

        private void LoadLoptoCombobox()
        {
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((cbNamHoc.SelectedItem as NamHoc).MaNamHoc);
            cbLop.DisplayMember = "TENLOP";
            cbLop.ValueMember = "MALOP";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemHS_Load(object sender, EventArgs e)
        {
            LoadNamHoctoCombobox();
            
           /* var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
            Top = _point.Y;
            Left = _point.X - Width;*/
        }

        private string GetGioiTinh()
        {
            if (rbtnNam.Checked)
                return rbtnNam.Text;
            else 
                return rbtnNu.Text;
        }

        private void ThemHocSinh(string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            if (HocSinhBUS.Instance.ThemHocSinh(ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme))
            {
                MessageBox.Show("Thêm học sinh mới thành công!");
            }
            else
                MessageBox.Show("Thêm học sinh mới thất bại!");
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string hoten = txtHoTen.Text;
            string gioitinh = GetGioiTinh();
            string ngaysinh = dtpkNgaySinh.Value.ToString("MM/dd/yyyy");
            int malop = (cbLop.SelectedItem as Lop).MaLop;
            string ngayvaohoc = dtpkNgayVaoHoc.Value.Date.ToString("MM/dd/yyyy");
            string diachi = txtDiaChi.Text;
            string tencha = txtHoTenCha.Text;
            string sdtcha = txtSDTCha.Text;
            string tenme = txtHoTenMe.Text;
            string sdtme = txtSDTMe.Text;
            ThemHocSinh(hoten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            this.Dispose();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
        }
    }
}
