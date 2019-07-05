using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNT;
using DTO_QLNT;

namespace GUI_QLNT
{
    public partial class UC_TimKiem : UserControl
    {
        public UC_TimKiem()
        {
            InitializeComponent();
        }





        public void TimKiem()
        {
            
            string keyword = txtTen.Text.Trim();
            DataTable dt = new DataTable();
            dt = HocSinhBUS.Instance.GetHocSinhByKeyWord(keyword);
            if (dt.Rows.Count > 0)
            {
                label1.Show(); 

                dgvKetQua.DataSource = dt;

                dgvKetQua.Columns[0].Visible = true;
                dgvKetQua.Columns[1].HeaderText = "Họ tên";
                dgvKetQua.Columns[2].HeaderText = "Giới tính";
                dgvKetQua.Columns[3].HeaderText = "Ngày sinh";
                dgvKetQua.Columns[4].HeaderText = "Lớp";
                dgvKetQua.Columns[5].HeaderText = "Khối";
                dgvKetQua.Columns[6].HeaderText = "Năm học";
                dgvKetQua.Columns[7].HeaderText = "Ngày vào học";
                dgvKetQua.Columns[8].HeaderText = "Địa chỉ";
                dgvKetQua.Columns[9].HeaderText = "Họ tên cha";
                dgvKetQua.Columns[10].HeaderText = "Điện thoại";
                dgvKetQua.Columns[11].HeaderText = "Họ tên mẹ";
                dgvKetQua.Columns[12].HeaderText = "Điện thoại";
            }
            else
            {
                label2.Show();
            }
               

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập gì cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else TimKiem();
        }

        private void txtTen_Enter(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            dgvKetQua.DataSource = null;
            dgvKetQua.Columns[0].Visible = false;
        }

        private void dgvKetQua_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvKetQua.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
