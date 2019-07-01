using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class UsersDAL
    {
        private static UsersDAL instance;
        public static UsersDAL Instance
        {
            get { if (instance == null) instance = new UsersDAL(); return UsersDAL.instance; }
            private set { UsersDAL.instance = value; }
        }
        private UsersDAL() { }
        public List<UsersDTO> GetListUsers()
        {
            List<UsersDTO> list = new List<UsersDTO>();
            string query = string.Format("SELECT * FROM NGUOIDUNG ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                UsersDTO giaovien = new UsersDTO(item);
                list.Add(giaovien);
            }
            return list;
        }
        public UsersDTO GetUsers()

        {
            string query = string.Format("SELECT * FROM NGUOIDUNG");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            UsersDTO us = new UsersDTO(dt.Rows[0]);
            return us;
        }
        public UsersDTO GetUsersById(int id)
        {
            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE ID={0}", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            UsersDTO us = new UsersDTO(dt.Rows[0]);
            return us;
        }
        public bool ThemUsers(string taiKhoan, string matKhau, int maGV, string quyen)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO NGUOIDUNG(TAIKHOAN,MATKHAU,MAGV,QUYEN) VALUES (N'{0}','{1}','{2}','{3}')", taiKhoan, matKhau, maGV, quyen);
            //string query = string.Format("INSERT INTO GIAOVIEN VALUES (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}')", hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, maLop, tonGiao);

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
       
    }
}
