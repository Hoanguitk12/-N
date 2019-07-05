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
    public partial class frmSuaLop : Form
    {
        public frmSuaLop()
        {
            InitializeComponent();
        }
        string maLop;
        public frmSuaLop(Lop l)
        {
            InitializeComponent();
            maLop = l.MaLop.ToString();
            txtTenLop.Text = l.TenLop;
           
            cbKhoi.DisplayMember = "TenKhoi";
            cbKhoi.ValueMember = "MaKhoi";
            cbKhoi.DataSource = KhoiBUS.Instance.GetKhoi();
            cbKhoi.SelectedValue = l.MaKhoi;

            
            cbNamHoc.DisplayMember = "NamBDKT";
            cbNamHoc.ValueMember = "MaNamHoc";
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
            cbNamHoc.SelectedValue = l.MaNamHoc;
        }
        private void SuaLop(string maLop, string tenLop, string maKhoi, string maNH)
        {
            if (LopBUS.Instance.SuaLop(maLop, tenLop, maKhoi, maNH))
             {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenLop = txtTenLop.Text;
                string maKhoi = (cbKhoi.SelectedItem as Khoi).MaKhoi.ToString();
                string maNH = (cbNamHoc.SelectedItem as NamHoc).MaNamHoc.ToString();
                SuaLop(maLop,tenLop, maKhoi, maNH);
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
