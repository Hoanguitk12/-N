using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        //public List<NguoiDung> GetListUsers()
        //{
        //    List<NguoiDung> list = new List<NguoiDung>();
        //    string query = string.Format("SELECT * FROM NGUOIDUNG Where QUYEN = N'Giáo viên' OR QUYEN = N'Ban giám hiệu' ORDER BY QUYEN");
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        NguoiDung user = new NguoiDung(item);
        //        list.Add(user);
        //    }
        //    return list;
        //}
        
        public DataTable GetDSNguoiDung()
        {
            DataTable dt = new DataTable();
            string query = string.Empty;

            query += "SELECT ID, TAIKHOAN, NGUOIDUNG.MAGV, GIAOVIEN.HOTEN, QUYEN ";
            query += "FROM NGUOIDUNG, GIAOVIEN ";
            query += "WHERE NGUOIDUNG.MAGV=GIAOVIEN.MAGV and (QUYEN = N'Giáo viên' or QUYEN = N'Ban giám hiệu') ORDER BY QUYEN";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public NguoiDung GetUsersById(int id)
        {
            string query = string.Format("SELECT ID, TAIKHOAN, MAGV, QUYEN FROM NGUOIDUNG WHERE ID={0}", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            NguoiDung us = new NguoiDung(dt.Rows[0]);
            return us;
        }



        public bool ThemUsers(string taiKhoan, int maGV, string quyen)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO NGUOIDUNG(TAIKHOAN,MAGV,QUYEN) VALUES ('{0}','{1}',N'{2}')", taiKhoan, maGV, quyen);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaUsers(int id, string taiKhoan, int maGV, string quyen)
        {
            int kq = 0;
            string query = string.Format("UPDATE NGUOIDUNG SET TAIKHOAN = '{0}', MAGV = '{1}', QUYEN = N'{2}' WHERE ID = {3}", taiKhoan, maGV, quyen, id);
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

        public string getID(string taikhoan, string matkhau)
        {
            string id = string.Empty;

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matkhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = string.Format("SELECT * FROM NGUOIDUNG WHERE TAIKHOAN = '{0}' AND MATKHAU = '{1}'", taikhoan, hasPass);

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if ( dt!= null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    id = dr["ID"].ToString();
                }
            }
            return id;
        }

        public string GetQuyen(string id)
        {
            string quyen = string.Empty;
            string query = string.Format("SELECT QUYEN FROM NGUOIDUNG WHERE ID = {0}", id);
            quyen = DataProvider.Instance.ExecuteScalar(query).ToString();
            return quyen;
        }

        public string[] getthongtinlop(string id) // lớp của gv đang dạy (chủ tk)
        {
            string[] thongtinlop = new string[2];
            string query = string.Empty;
            query += "SELECT  LOP.MANAMHOC, GIAOVIEN.MALOP ";
            query += "FROM NGUOIDUNG, GIAOVIEN, LOP ";
            query += string.Format("WHERE NGUOIDUNG.MAGV = GIAOVIEN.MAGV AND GIAOVIEN.MALOP=LOP.MALOP AND ID = {0}", id);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    thongtinlop[0]=(dr["MANAMHOC"].ToString());
                    thongtinlop[1]=(dr["MALOP"].ToString());
                }
            }
            return thongtinlop;
        }

        public bool DMK(int id, string mkcu,string mkmoi)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mkcu);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasmkcu = "";

            foreach (byte item in hasData)
            {
                hasmkcu += item;
            }

            temp = ASCIIEncoding.ASCII.GetBytes(mkmoi);
            hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasmkmoi = "";

            foreach (byte item in hasData)
            {
                hasmkmoi += item;
            }

            string query = string.Empty;
            query += string.Format("UPDATE NGUOIDUNG SET MATKHAU = '{0}' WHERE ID={1} AND MATKHAU='{2}'",hasmkmoi,id,hasmkcu);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
