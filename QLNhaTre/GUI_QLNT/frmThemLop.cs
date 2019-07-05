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
    public partial class frmThemLop : Form
    {
        public frmThemLop()
        {
            InitializeComponent();
        }
        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.DisplayMember = "NamBDKT";
            cbNamHoc.ValueMember = "MaNamHoc";
        }
        private void LoadKhoitoCombobox()
        {
            
            cbKhoi.DisplayMember = "TenKhoi";
            cbKhoi.ValueMember = "MaKhoi";
            cbKhoi.DataSource = KhoiBUS.Instance.GetKhoi();
        }
        private void ThemLop(string tenLop,string maKhoi,string maNH)
        {
            if (LopBUS.Instance.ThemLop(tenLop, maKhoi, maNH))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLop.Focus();
            }
            else
            {
                string tenLop = txtTenLop.Text;
                string maKhoi = (cbKhoi.SelectedItem as Khoi).MaKhoi.ToString();
                string maNH = (cbNamHoc.SelectedItem as NamHoc).MaNamHoc.ToString();
                ThemLop(tenLop, maKhoi, maNH);
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmThemLop_Load(object sender, EventArgs e)
        {
            LoadKhoitoCombobox();
            LoadNamHoctoCombobox();
        }
    }
}
