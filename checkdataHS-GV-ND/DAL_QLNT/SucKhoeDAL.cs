using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class SucKhoeDAL
    {
        private static SucKhoeDAL instance;
        private SucKhoeDAL() { }
        public static SucKhoeDAL Instance
        {
            get { if (instance == null) instance = new SucKhoeDAL(); return SucKhoeDAL.instance; }
            private set { SucKhoeDAL.instance = value; }
        }

        public DataTable GetSucKhoe(int malop,int thangdo)
        {
            string query = string.Format("SELECT * FROM SUCKHOE WHERE MALOP={0} AND THANGDO = {1}", malop, thangdo);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool ThemSucKhoe(int mahs, int malop, int thangdo, float chieucao, string dgcc, float cannang, string dgcn, string dgc)
        {
            int kq = 0;
            string query = string.Format("INSERT INTO SUCKHOE VALUES ({0},{1},{2},{3},N'{4}',{5},N'{6}',N'{7}')", mahs, malop, thangdo, chieucao, dgcc, cannang, dgcn, dgc);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaSucKhoe(int mask, float chieucao, string dgcc, float cannang, string dgcn, string dgc)
        {
            int kq = 0;
            string query = string.Format("UPDATE SUCKHOE SET CHIEUCAO={0}, DGCC=N'{1}', CANNANG={2}, DGCN=N'{3}', DGC=N'{4}' WHERE MASK={5}", chieucao, dgcc, cannang, dgcn, dgc, mask);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
    }
}
