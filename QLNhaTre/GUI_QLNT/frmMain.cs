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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
            moveSidePanel(btnGiaoVien);
            UC_GiaoVien uC_GiaoVien = new UC_GiaoVien();
            AddControlsToPanel(uC_GiaoVien);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHeThong);
            UC_HeThong uC_HeThong = new UC_HeThong();
            AddControlsToPanel(uC_HeThong);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
