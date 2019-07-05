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
    public partial class frmSuaNamHoc : Form
    {
        public frmSuaNamHoc()
        {
            InitializeComponent();
        }
        int maNH;
        public frmSuaNamHoc(DTO_QLNT.NamHoc nh)

        {
            InitializeComponent();
            maNH = nh.MaNamHoc;
           string nambd= nh.NamBD.ToString();
            txtNBD.Text = nambd;

            
            txtNKT.Text = nh.NamKT.ToString();

        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        } 
        
        private void SuaNamHoc(int MaNH,string NamBD,string NamKT)
        {
            if (NamHocBUS.Instance.SuaNamHoc(maNH, NamBD, NamKT))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        bool CheckData()
        {
            if (IsNumber(txtNBD.Text)==false)
            {

                MessageBox.Show("Năm bắt đầu chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNBD.Focus();
                return false;
            }
            if (IsNumber(txtNKT.Text)==false)
            {
                MessageBox.Show("Năm kết thúc chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNKT.Focus();
                return false;
            }
            if(int.Parse(txtNKT.Text)<int.Parse(txtNBD.Text))
            {
                MessageBox.Show("Năm kết thúc chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNKT.Focus();
                return false;
            }

            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {

                string namBD = txtNBD.Text;
                string namKT = txtNKT.Text;
                SuaNamHoc(maNH, namBD, namKT);
                this.Dispose();
            }
        }
    }
}
