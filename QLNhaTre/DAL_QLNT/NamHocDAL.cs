using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class NamHocDAL
    {
        private static NamHocDAL instance;

        private NamHocDAL() { }

        public static NamHocDAL Instance
        {
            get { if (instance == null) instance = new NamHocDAL(); return NamHocDAL.instance; }
            private set { NamHocDAL.instance = value; }
        }

        public List<NamHoc> GetNamHoc()
        {
            List<NamHoc> list = new List<NamHoc>();
            string query = "SELECT * FROM NAMHOC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NamHoc nam = new NamHoc(item);
                list.Add(nam);
            }

            return list;
        }
        public NamHoc GetNamHocByMaNH(int maNH)
        {
            string query = string.Format("SELECT * FROM NAMHOC WHERE MANAMHOC={0}", maNH);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTO_QLNT.NamHoc nh = new DTO_QLNT.NamHoc(dt.Rows[0]);
            return nh;
        }
        public bool ThemNamHoc(string NamBD, string NamKT)
        {
            int kq = 0;
            string query = string.Format("INSERT INTO NAMHOC(NAMBD,NAMKT) VALUES ('{0}','{1}')", NamBD, NamKT);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
        public bool SuaNamHoc(int MaNH, string NamBD, string NamKT)
        {
            int kq = 0;
            string query = string.Format("UPDATE NAMHOC SET NAMBD = '{0}', NAMKT = '{1}' WHERE MANAMHOC = '{2}'", NamBD, NamKT, MaNH);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;

        }
        public bool XoaNamHoc(int MaNH)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM NAMHOC WHERE MANAMHOC={0}", MaNH);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }


    }
}
