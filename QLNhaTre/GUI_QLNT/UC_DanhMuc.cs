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
using System.Data.SqlClient;

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
            gridNguoiDung.DataSource = NguoiDungBUS.Instance.GetDSNguoiDung();

            gridNguoiDung.Columns[0].Visible = true;
            gridNguoiDung.Columns[1].Visible = false;
            gridNguoiDung.Columns[3].Visible = false;

            gridNguoiDung.Columns[2].HeaderText = "Tài Khoản";
            gridNguoiDung.Columns[4].HeaderText = "Tên giáo viên";
            gridNguoiDung.Columns[5].HeaderText = "Quyền";
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
        private void LoadLopToDGV()
        {
            gridLop.DataSource = LopBUS.Instance.GetLop();
            gridLop.Columns[1].Visible = false;
            gridLop.Columns[2].HeaderText = "Tên Lớp";
            gridLop.Columns[3].HeaderText = "Khối";
            gridLop.Columns[4].HeaderText = "Năm học";

        }
        private void LoadKhoiToDGV()
        {
            gridKhoi.DataSource = KhoiBUS.Instance.GetKhoitodgv();
            gridKhoi.Columns[1].Visible = false;
            gridKhoi.Columns[2].HeaderText = "Tên khối";
            gridKhoi.Columns[2].ReadOnly = true;
            gridKhoi.Columns[3].HeaderText = "Sỉ số tối đa";
            
        }
        /*private void dgvNamHoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNamHoc.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }*/

        private void UC_HeThong_Load(object sender, EventArgs e)
        {
            LoadNamHocToDGV();
            LoadDSNDtodtgv();
            LoadLopToDGV();
            LoadKhoiToDGV();
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

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnThemN_Click(object sender, EventArgs e)
        {
            frmThemNamHoc fThemNamHoc = new frmThemNamHoc();
            fThemNamHoc.ShowDialog();
            LoadNamHocToDGV();
        }

        private void btnSuaN_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.SelectedRows.Count != 0)
            {
                int maNH = (int)dgvNamHoc.Rows[dgvNamHoc.SelectedRows[0].Index].Cells[1].Value;
                DTO_QLNT.NamHoc nh = NamHocBUS.Instance.GetNamHocByMaNH(maNH);
                frmSuaNamHoc fsua = new frmSuaNamHoc(nh);
                fsua.ShowDialog();
                LoadNamHocToDGV();
            }
            else
            {
                MessageBox.Show("Hãy chọn năm học muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.SelectedRows.Count > 0)
            {
                bool kq = false;
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int id;
                    id = (int)dgvNamHoc.Rows[dgvNamHoc.SelectedRows[0].Index].Cells[1].Value;


                    try
                    {
                        kq = NamHocBUS.Instance.XoaNamHoc(id);
                    }
                    catch (SqlException sqlex)
                    {
                        if (sqlex.Message.Contains("FK__LOP__MANAMHOC__20C1E124"))
                        {
                            MessageBox.Show("Không thể xóa năm học đang sử dụng");
                        }


                    }
                    finally
                    {
                        if (kq)
                        {
                            MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNamHocToDGV();
                        }
                        else
                            MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemL_Click(object sender, EventArgs e)
        {
            frmThemLop fThemLop = new frmThemLop();
            fThemLop.ShowDialog();
            LoadLopToDGV();
        }

        private void btnSuaL_Click(object sender, EventArgs e)
        {
            if (gridLop.SelectedRows.Count != 0)
            {
                int maLop = (int)gridLop.Rows[gridLop.SelectedRows[0].Index].Cells[1].Value;
                Lop l = LopBUS.Instance.GetLopbyMaLop(maLop);
                frmSuaLop fsua = new frmSuaLop(l);
                fsua.ShowDialog();
                LoadLopToDGV();
            }
            else
            {
                MessageBox.Show("Hãy chọn Lớp muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaL_Click(object sender, EventArgs e)
        {

            if (gridLop.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này sẽ xóa tất cả dữ liệu trong lớp.\nXóa?", "Cảnh báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int id;
                    id = (int)gridLop.Rows[gridLop.SelectedRows[0].Index].Cells[1].Value;
                    if (LopBUS.Instance.XoaLop(id.ToString()))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLopToDGV();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridLop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gridLop.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvNamHoc_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvNamHoc.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void gridKhoi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gridKhoi.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_Click(object sender, EventArgs e)//button cập nhật khối
        {

            System.Data.DataTable dt = ((System.Data.DataTable)gridKhoi.DataSource).GetChanges(DataRowState.Modified);
            if (dt != null)
            {
                var changedRows = ((System.Data.DataTable)gridKhoi.DataSource).GetChanges(DataRowState.Modified).Rows;

                foreach (DataRow row in changedRows)
                {
                    int sstd = int.Parse(row["SSTOIDA"].ToString());
                    int maKhoi = (int)row["MAKHOI"];
                    KhoiBUS.Instance.SuaKhoi(maKhoi, sstd);
                    MessageBox.Show("Đã cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhoiToDGV();
                }
            }
            else
            {
                MessageBox.Show("Không có thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CellOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

       
        private void gridKhoi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(CellOnlyNumber_KeyPress);
            if (gridKhoi.CurrentCell.ColumnIndex ==  3)
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(CellOnlyNumber_KeyPress);
                }
            }
        }
        
    }
}

