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

    }
}
