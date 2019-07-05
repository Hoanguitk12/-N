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


namespace GUI_QLNT
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        public static string QUYEN = string.Empty;


        private void frmMain_Load(object sender, EventArgs e)
        {
            QUYEN = NguoiDungBUS.Instance.GetQuyen(frmLogin.ID_USER);
            UC_HocSinh uC_HocSinh = new UC_HocSinh();
            AddControlsToPanel(uC_HocSinh);
        }

        private void moveSidePanel(Control btn)
        {
            pnlSide.Top = btn.Top;
            pnlSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            
            while (pnlControl.Controls.Count > 0)
            {
                pnlControl.Controls[0].Dispose();
            }
            c.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(c);
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHocSinh);
            UC_HocSinh uC_HocSinh = new UC_HocSinh();
            AddControlsToPanel(uC_HocSinh);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            if (checkQuyen(QUYEN))
            {
                moveSidePanel(btnGiaoVien);
                UC_GiaoVien uC_GiaoVien = new UC_GiaoVien();
                AddControlsToPanel(uC_GiaoVien);
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (checkQuyen(QUYEN))
            {
                moveSidePanel(btnHeThong);
                UC_DanhMuc uC_HeThong = new UC_DanhMuc();
                AddControlsToPanel(uC_HeThong);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTimKiem);
            UC_TimKiem uC = new UC_TimKiem();
            AddControlsToPanel(uC);
        }


        private bool checkQuyen(string quyen)
        {
            if(quyen=="Giáo viên")
            {
                MessageBox.Show("Tài khoản của bạn không đủ quyền truy cập");
                return false;
            }
            return true;
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDMK dmk = new frmDMK();
            dmk.ShowDialog();
        }
    }
}
