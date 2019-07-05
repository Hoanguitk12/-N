using BUS_QLNT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNT
{
    public partial class frmThemNamHoc : Form
    {
        public frmThemNamHoc()
        {
            InitializeComponent();
        }
        private void ThemNamHoc( string namBD,string namKT)
        {
            if (NamHocBUS.Instance.ThemNamHoc(namBD, namKT))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        bool CheckData()
        {
            if (IsNumber(txtNBD.Text) == false)
            {

                MessageBox.Show("Năm bắt đầu chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNBD.Focus();
                return false;
            }
            if (IsNumber(txtNKT.Text) == false)
            {
                MessageBox.Show("Năm kết thúc chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNKT.Focus();
                return false;
            }
            if (int.Parse(txtNKT.Text) < int.Parse(txtNBD.Text))
            {
                MessageBox.Show("Năm kết thúc chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNKT.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string namBD = txtNBD.Text;
                string namKT = txtNKT.Text;
                ThemNamHoc(namBD, namKT);
                this.Dispose();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
