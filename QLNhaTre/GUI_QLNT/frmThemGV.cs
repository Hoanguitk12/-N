using BUS_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string GetGioiTinh()
        {
            if (rbtnNam.Checked == true)
            {
                return rbtnNam.Text;
            }
            else
            {
                return rbtnNu.Text;
            }

        }
        private void ThemGiaoVien(string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tongiao)
        {
            if (GiaoVienBUS.Instance.ThemGiaoVien(hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tongiao))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        bool CheckData()
        {
            if(string.IsNullOrEmpty(txtHoTen.Text)||isName(txtHoTen.Text)==false)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;

            }
            if (rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (isDoB(dtpkNgaySinh.Value.Date) == false)
            {
                MessageBox.Show("Ngày sinh phải tù 18-50", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpkNgaySinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDanToc.Text))
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;

            }
            if(string.IsNullOrEmpty(txtTonGiao.Text))
            {
                MessageBox.Show("Bạn chưa nhập tôn giáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text)||isPhoneNumber(txtSDT.Text)==false)
            {
                MessageBox.Show("sdt hợp lệ là từ 9-11 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTrinhDo.Text))
            {
                MessageBox.Show("Bạn chưa nhập trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(GetGioiTinh()))
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            
            if(IsNgayVaoLam(dtpkNgayVaoLam.Value.Date)==false)
            {
                MessageBox.Show("Ngày vào làm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpkNgayVaoLam.Focus();
                return false;
            }
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string hoTen = txtHoTen.Text;
                string gioitinh = GetGioiTinh();
                string ngaysinh = dtpkNgaySinh.Value.Date.ToString("MM/dd/yyyy");
                string dantoc = txtDanToc.Text;
                string tongiao = txtTonGiao.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string ngayvaolam = dtpkNgayVaoLam.Value.Date.ToString("MM/dd/yyyy");
                string trinhdo = txtTrinhDo.Text;
                ThemGiaoVien(hoTen, gioitinh, ngaysinh, dantoc, diachi, sdt, trinhdo, ngayvaolam, tongiao);
                this.Dispose();
            }
        }
        // chuẩn hóa họ tên
        public static string FormatProperCase(string str)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }
        //kiểm tra sdt
        private bool isPhoneNumber(string pText)
        {
            Regex regex = new Regex(@"^\d{9,11}$");
            return regex.IsMatch(pText);
        }
        //kierm tra tên
        private bool isName(string pText)
        {
            Regex regex = new Regex(@"\D[^~!@#$%^&*()_+-=\]{}|:'<>,.?`\/\\]{1,}$");
            return regex.IsMatch(pText);
        }
        private bool isDoB(DateTime date)
        {
            DateTime now = DateTime.Now;
            if (17 < now.Year - date.Year && now.Year - date.Year < 51)
                return true;
            else return false;
        }
        private bool IsNgayVaoLam(DateTime dt)
        {
            if (dt.Year == DateTime.Now.Year)
            {
                if (dt.Month == DateTime.Now.Month)
                {
                    if (DateTime.Now.Day - dt.Day >= 0)
                        return true;
                    else
                        return false;
                }

            }

            if (dt.Year == DateTime.Now.Year)
            {
                if (dt.Month <= DateTime.Now.Month)
                    return true;
                else return false;
            }
            if (dt.Year <= DateTime.Now.Year)
                return true;
            else
                return false;
        }
        

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.Text = FormatProperCase(txtHoTen.Text);
        }
    }
}
