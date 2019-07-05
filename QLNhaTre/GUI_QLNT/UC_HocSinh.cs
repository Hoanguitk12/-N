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
using Microsoft.Office.Interop.Excel;



namespace GUI_QLNT
{
    public partial class UC_HocSinh : UserControl
    {
        public UC_HocSinh()
        {
            InitializeComponent();
        }

        #region event

        private void UC_HocSinh_Load(object sender, EventArgs e)
        {
            LoadNamHoctoCombobox();
            cbThangdo.SelectedIndex = DateTime.Now.Month - 1;


            if (frmMain.QUYEN == "Giáo viên")
            {
                string[] thongtinlop = NguoiDungBUS.Instance.GetThongTinLop(frmLogin.ID_USER);
                cbNamHoc.SelectedValue = int.Parse(thongtinlop[0]);
                cbLop.SelectedValue = int.Parse(thongtinlop[1]);

                cbNamHoc.Enabled = false;
                cbLop.Enabled = false;
            }
        }



        private void dgvDSHS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)// auto đánh stt
        {
            dgvDSHS.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvSK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvSK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void tabctrlHocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabDSHS)
            {
                btnLuu.Hide();
                label3.Hide();
                cbThangdo.Hide();
                btnBaoCao.Hide();
                btnThem.Show();
                btnSua.Show();
                btnXoa.Show();
                LoadDSHocSinhtodtgv();
            }
            else
            {
                btnLuu.Show();
                label3.Show();
                cbThangdo.Show();
                btnBaoCao.Show();
                btnThem.Hide();
                btnSua.Hide();
                btnXoa.Hide();
                LoadSucKhoe();
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoptoCombobox();
            if (tabctrlHocsinh.SelectedTab == tabSK)
                LoadSucKhoe();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabDSHS)
                LoadDSHocSinhtodtgv();
            else
                LoadSucKhoe();
        }


        private void cbThangdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabctrlHocsinh.SelectedTab == tabSK)
                LoadSucKhoe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHS fthem = new frmThemHS();
            fthem.ShowDialog();
            LoadDSHocSinhtodtgv();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHS.SelectedRows.Count != 0)
            {
                int mahs = (int)dgvDSHS.Rows[dgvDSHS.SelectedRows[0].Index].Cells[1].Value;
                HocSinh hs = HocSinhBUS.Instance.GetHocSinhByMaHS(mahs);
                frmSuaHS fsua = new frmSuaHS(hs, (int)cbNamHoc.SelectedValue);
                fsua.ShowDialog();
                LoadDSHocSinhtodtgv();
            }
            else
            {
                MessageBox.Show("Hãy chọn học sinh muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHS.SelectedRows.Count == 1)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int mahs;
                    mahs = (int)dgvDSHS.Rows[dgvDSHS.SelectedRows[0].Index].Cells[1].Value;
                    if (HocSinhBUS.Instance.XoaHocSinh(mahs))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSHocSinhtodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn học sinh muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.DataTable dt = ((System.Data.DataTable)dgvSK.DataSource).GetChanges(DataRowState.Modified);
                if (dt != null)
                {
                    var changedRows = ((System.Data.DataTable)dgvSK.DataSource).GetChanges(DataRowState.Modified).Rows;

                    foreach (DataRow row in changedRows)
                    {

                        if (row["CHIEUCAO"].ToString() != "" && row["CANNANG"].ToString() != "")
                        {
                            float chieucao = float.Parse(row["CHIEUCAO"].ToString());
                            string dgcc = row["DGCC"].ToString();
                            float cannang = float.Parse(row["CANNANG"].ToString());
                            string dgcn = row["DGCN"].ToString();
                            string dgc = row["DGC"].ToString();
                            if (row["MASK"].ToString() == "")
                            {
                                int mahs = (int)row["MAHS"];

                                string thangdo = cbThangdo.SelectedItem.ToString();

                                SucKhoeBUS.Instance.ThemSucKhoe(mahs, Convert.ToInt32(thangdo), chieucao, dgcc, cannang, dgcn, dgc);
                            }
                            else
                            {
                                int mask = (int)row["MASK"];

                                SucKhoeBUS.Instance.SuaSucKhoe(mask, chieucao, dgcc, cannang, dgcn, dgc);
                            }
                            MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadSucKhoe();
                        }
                        else if (row["CHIEUCAO"].ToString() == "" && row["CANNANG"].ToString() == "" && row["MASK"].ToString() == "")
                        {
                            MessageBox.Show("Không có thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (row["CHIEUCAO"].ToString() == "" || row["CANNANG"].ToString() == "")
                        {
                            MessageBox.Show("Xin hãy nhập cả chiều cao và cân nặng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu");
            }
            
            

        }
        private void CellOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dgvSK_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(CellOnlyNumber_KeyPress);
            if (dgvSK.CurrentCell.ColumnIndex == 6 || dgvSK.CurrentCell.ColumnIndex == 8)
            {
                System.Windows.Forms.TextBox tb = e.Control as System.Windows.Forms.TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(CellOnlyNumber_KeyPress);
                }
            }
        }

        #endregion


        #region hàm

        private void LoadLoptoCombobox()
        {
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaLop";
            cbLop.DataSource = LopBUS.Instance.GetLopByMaNamHoc((int)cbNamHoc.SelectedValue);
        }

        private void LoadNamHoctoCombobox()
        {
            cbNamHoc.DisplayMember = "NamBDKT";
            cbNamHoc.ValueMember = "MaNamHoc";
            cbNamHoc.DataSource = NamHocBUS.Instance.GetNamHoc();
        }

        private void LoadDSHocSinhtodtgv()
        {
            if (cbLop.SelectedItem != null)
            {
                int malop = (cbLop.SelectedItem as Lop).MaLop;

                dgvDSHS.DataSource = HocSinhBUS.Instance.GetHocSinhByMaLop(malop);
                dgvDSHS.Columns[0].Visible = true;
                dgvDSHS.Columns[1].Visible = false;//ẩn cột mã học sinh;
                dgvDSHS.Columns[2].HeaderText = "Họ tên";
                dgvDSHS.Columns[3].HeaderText = "Giới tính";
                dgvDSHS.Columns[4].HeaderText = "Ngày sinh";
                dgvDSHS.Columns[5].Visible = false;//ẩn cột mã lớp
                dgvDSHS.Columns[6].HeaderText = "Ngày vào học";
                dgvDSHS.Columns[7].HeaderText = "Địa chỉ";
                dgvDSHS.Columns[8].HeaderText = "Họ tên cha";
                dgvDSHS.Columns[9].HeaderText = "Điện thoại";
                dgvDSHS.Columns[10].HeaderText = "Họ tên mẹ";
                dgvDSHS.Columns[11].HeaderText = "Điện thoại";
                dgvDSHS.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDSHS.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDSHS.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvDSHS.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        public void LoadSucKhoe()
        {
            if (cbLop.SelectedItem != null)
            {
                int malop = (cbLop.SelectedItem as Lop).MaLop;
                string thangdo = cbThangdo.SelectedItem.ToString();


                System.Data.DataTable dths = HocSinhBUS.Instance.GetHocSinh(malop);
                dths.PrimaryKey = new DataColumn[]
                {
                dths.Columns["MAHS"]
                };
                System.Data.DataTable dtsk = SucKhoeBUS.Instance.GetSucKhoe(malop, Convert.ToInt32(thangdo));
                dtsk.PrimaryKey = new DataColumn[]
                {
                dtsk.Columns["MAHS"]
                };

                dths.Merge(dtsk);
                dgvSK.DataSource = dths;
                dgvSK.Columns[0].Visible = true;//cot stt
                dgvSK.Columns[1].Visible = false;//cot mahs
                dgvSK.Columns[5].Visible = false;//cot mask



                dgvSK.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSK.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSK.Columns[0].ReadOnly = true;
                dgvSK.Columns[2].ReadOnly = true;
                dgvSK.Columns[3].ReadOnly = true;
                dgvSK.Columns[4].ReadOnly = true;



                dgvSK.Columns[2].HeaderText = "Họ tên";
                dgvSK.Columns[3].HeaderText = "Giới tính";
                dgvSK.Columns[4].HeaderText = "Ngày sinh";
                dgvSK.Columns[6].HeaderText = "Chiều cao";
                dgvSK.Columns[7].HeaderText = "ĐGCC";
                dgvSK.Columns[8].HeaderText = "Cân nặng";
                dgvSK.Columns[9].HeaderText = "ĐGCN";
                dgvSK.Columns[10].HeaderText = "Đánh giá";
            }
        }






        #endregion

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvSK.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);


                excelApp.Cells[1, 1] = dgvSK.Columns[0].HeaderText;
                excelApp.Cells[1, 2] = dgvSK.Columns[2].HeaderText;
                excelApp.Cells[1, 3] = dgvSK.Columns[3].HeaderText;
                excelApp.Cells[1, 4] = dgvSK.Columns[4].HeaderText;
                excelApp.Cells[1, 5] = dgvSK.Columns[6].HeaderText;
                excelApp.Cells[1, 6] = dgvSK.Columns[7].HeaderText;
                excelApp.Cells[1, 7] = dgvSK.Columns[8].HeaderText;
                excelApp.Cells[1, 8] = dgvSK.Columns[9].HeaderText;
                excelApp.Cells[1, 9] = dgvSK.Columns[10].HeaderText;

                for (int i = 0; i < dgvSK.Rows.Count; i++)
                {
                    excelApp.Cells[i + 2, 1] = dgvSK.Rows[i].Cells[0].Value;
                    excelApp.Cells[i + 2, 2] = dgvSK.Rows[i].Cells[2].Value;
                    excelApp.Cells[i + 2, 3] = dgvSK.Rows[i].Cells[3].Value;
                    excelApp.Cells[i + 2, 4] = dgvSK.Rows[i].Cells[4].Value;
                    excelApp.Cells[i + 2, 5] = dgvSK.Rows[i].Cells[6].Value;
                    excelApp.Cells[i + 2, 6] = dgvSK.Rows[i].Cells[7].Value;
                    excelApp.Cells[i + 2, 7] = dgvSK.Rows[i].Cells[8].Value;
                    excelApp.Cells[i + 2, 8] = dgvSK.Rows[i].Cells[9].Value;
                    excelApp.Cells[i + 2, 9] = dgvSK.Rows[i].Cells[10].Value;
                }

                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
        }


    }

}
