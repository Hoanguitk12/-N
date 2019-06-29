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
    public partial class UC_GiaoVien : UserControl
    {
        #region event
      
       
        public UC_GiaoVien()
        {
            InitializeComponent();
            LoadDSGVtodtgv();
           

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGV fthemgv = new frmThemGV();
            fthemgv.ShowDialog();
            LoadDSGVtodtgv();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gridDSGV.SelectedRows.Count != 0)
            {
               int maGV = (int)gridDSGV.Rows[gridDSGV.SelectedRows[0].Index].Cells[1].Value;
                DTO_QLNT.GiaoVien gv = GiaoVienBUS.Instance.GetGiaoVienByMaGV(maGV);
                frmSuaGV fsua = new frmSuaGV(gv);
                fsua.ShowDialog();
                LoadDSGVtodtgv();
            }
            else
            {
                MessageBox.Show("Hãy chọn học sinh muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridDSGV.SelectedRows != null)
            {
                DialogResult dr = MessageBox.Show(this, "Thao tác này không thể hoàn tác.\nXóa?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int maGV;
                   maGV = (int)gridDSGV.Rows[gridDSGV.SelectedRows[0].Index].Cells[1].Value;
                    if (GiaoVienBUS.Instance.XoaGiaoVien(maGV))
                    {
                        MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSGVtodtgv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn Giáo viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region ham
        private void LoadDSGVtodtgv()
        {



            gridDSGV.DataSource = GiaoVienBUS.Instance.GetLiistGiaoVien();
            gridDSGV.Columns[0].Visible = true;
           gridDSGV.Columns[1].Visible = false;//ẩn cột mã ;
          gridDSGV.Columns[2].HeaderText = "Họ tên";
           gridDSGV.Columns[3].HeaderText = "Giới tính";
           gridDSGV.Columns[4].HeaderText = "Ngày sinh";
            gridDSGV.Columns[5].HeaderText = "Dân tộc";
           gridDSGV.Columns[6].HeaderText = "Địa chỉ";
           gridDSGV.Columns[7].HeaderText = "SDT";
          gridDSGV.Columns[8].HeaderText = "Trình Độ";
          gridDSGV.Columns[9].HeaderText = "Ngày Vào Làm";
            gridDSGV.Columns[10].Visible = false;
            gridDSGV.Columns[11].HeaderText = "Tôn Giáo";

            gridDSGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          gridDSGV.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridDSGV.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
     gridDSGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }


        #endregion

        private void gridDSGV_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            gridDSGV.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
