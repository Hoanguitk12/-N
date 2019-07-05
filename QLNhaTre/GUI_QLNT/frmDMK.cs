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
    public partial class frmDMK : Form
    {
        public frmDMK()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMkmoi.Text == txtMkmoi2.Text)
            {
                if (NguoiDungBUS.Instance.DMK(Convert.ToInt16(frmLogin.ID_USER), txtMkcu.Text, txtMkmoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới chưa chính xác");
            }
        }
    }
}
