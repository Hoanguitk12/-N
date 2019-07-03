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
    public partial class UC_DanhMuc : UserControl
    {
        public UC_DanhMuc()
        {
            InitializeComponent();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmThemND fthemND = new frmThemND();
            fthemND.ShowDialog();
            LoadDSNDtodtgv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridNguoiDung.SelectedRows.Count != 0)
            {
                int id = (int)gridNguoiDung.Rows[gridNguoiDung.SelectedRows[0].Index].Cells[1].Value;
                NguoiDung us = NguoiDungBUS.Instance.GetUsersById(id);
                frmSuaND fsua = new frmSuaND(us);
                fsua.ShowDialog();
                LoadDSNDtodtgv();
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadDSNDtodtgv()
        {
            gridNguoiDung.DataSource = NguoiDungBUS.Instance.GetListUsers();
            gridNguoiDung.Columns[0].Visible = true;
            gridNguoiDung.Columns[1].Visible = false;
            gridNguoiDung.Columns[5].Visible = false;

            gridNguoiDung.Columns[2].HeaderText = "Tài Khoản";
            gridNguoiDung.Columns[3].HeaderText = "Mật Khẩu";
            gridNguoiDung.Columns[4].HeaderText = "Quyền";
            gridNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void LoadNamHocToDGV()
        {
            dgvNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();

            dgvNamHoc.Columns[1].Visible = false;
            dgvNamHoc.Columns[4].Visible = false;
            dgvNamHoc.Columns[2].HeaderText = "Năm bắt đầu";
            dgvNamHoc.Columns[3].HeaderText = "Năm kết thúc";
            dgvNamHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgvNamHoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNamHoc.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void UC_HeThong_Load(object sender, EventArgs e)
        {
            LoadNamHocToDGV();
            LoadDSNDtodtgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridNguoiDung.SelectedRows != null)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int id;
                    id = (int)gridNguoiDung.Rows[gridNguoiDung.SelectedRows[0].Index].Cells[1].Value;
                    if (NguoiDungBUS.Instance.XoaUsers(id))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSNDtodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn người dùng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridNguoiDung_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gridNguoiDung.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
