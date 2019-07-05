using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class LopDAL
    {
        private static LopDAL instance;
        private LopDAL() { }
        public static LopDAL Instance
        {
            get { if (instance == null) instance = new LopDAL(); return LopDAL.instance; }
            private set { LopDAL.instance = value; }
        }

        


        public List<Lop> GetLopByMaNamHoc(int manamhoc)
        {
            List<Lop> list = new List<Lop>();
            string query = string.Format("SELECT * FROM LOP WHERE MANAMHOC={0} ORDER BY TENLOP",manamhoc);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Lop lop = new Lop(item);
                list.Add(lop);
            }

            return list;
        }
        public Lop GetLopbyMaLop(int maLop)
        {
            string query = string.Format("SELECT * FROM LOP WHERE MALOP={0}", maLop);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            Lop l = new Lop(dt.Rows[0]);
            return l;
        }
        public DataTable GetLop()
        {
            string query = string.Format("SELECT LOP.MALOP, LOP.TENLOP, KHOILOP.TENKHOI, NAMHOC.NAMBDKT FROM LOP, KHOILOP, NAMHOC WHERE LOP.MAKHOI = KHOILOP.MAKHOI AND LOP.MANAMHOC = NAMHOC.MANAMHOC");


            //select t1.lop,
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public bool ThemLop(string tenLop, string maKhoi, string maNH)
        {
            int kq = 0;
            string query = string.Format("INSERT INTO LOP VALUES(N'{0}','{1}','{2}')", tenLop, maKhoi, maNH);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public bool SuaLop(string maLop, string tenLop, string maKhoi, string maNH)
        {
            int kq = 0;
            string query = string.Format("UPDATE LOP SET TENLOP=N'{0}',MAKHOI='{1}',MANAMHOC='{2}' WHERE MALOP='{3}'", tenLop, maKhoi, maNH, maLop);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public bool XoaLop(string maLop)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM LOP WHERE MALOP='{0}'", maLop);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

    }
}
