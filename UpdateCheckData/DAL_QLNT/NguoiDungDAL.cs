using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class NguoiDungDAL
    {
        private static NguoiDungDAL instance;
        public static NguoiDungDAL Instance
        {
            get { if (instance == null) instance = new NguoiDungDAL(); return NguoiDungDAL.instance; }
            private set { NguoiDungDAL.instance = value; }
        }
        private NguoiDungDAL() { }
        public List<NguoiDung> GetListUsers()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            string query = string.Format("SELECT * FROM NGUOIDUNG Where QUYEN = N'Giáo viên' OR QUYEN = N'Ban giám hiệu' ORDER BY QUYEN ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                NguoiDung user = new NguoiDung(item);
                list.Add(user);
            }
            return list;
        }
        public NguoiDung GetUsers()
        {
            string query = string.Format("SELECT * FROM NGUOIDUNG");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            NguoiDung us = new NguoiDung(dt.Rows[0]);
            return us;
        }
        public NguoiDung GetUsersById(int id)
        {
            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE ID={0}", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            NguoiDung us = new NguoiDung(dt.Rows[0]);
            return us;
        }
        public bool ThemUsers(string taiKhoan, string matKhau, int maGV, string quyen)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO NGUOIDUNG(TAIKHOAN,MATKHAU,MAGV,QUYEN) VALUES (N'{0}','{1}','{2}','{3}')", taiKhoan, matKhau, maGV, quyen);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaUsers(int id, string taiKhoan, string matKhau, int maGV, string quyen)
        {
            int kq = 0;
            string query = string.Format("UPDATE NGUOIDUNG SET TAIKHOAN = '{0}', MATKHAU = '{1}', MAGV = '{2}', QUYEN = N'{3}' WHERE ID = {4}", taiKhoan, matKhau, maGV, quyen, id);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool XoaUsers(int id)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM NGUOIDUNG WHERE ID={0}", id);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        
        public bool Check(string taikhoan)
        {
            int kq = 0;
            string query = string.Format("SELECT COUNT(ID) from NGUOIDUNG WHERE TAIKHOAN = '{0}'", taikhoan);
            kq = (int)DataProvider.Instance.ExecuteScalar(query);
            return kq > 0;
        }
        
    }
}
