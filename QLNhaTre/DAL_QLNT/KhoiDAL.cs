using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNT
{
    public class KhoiDAL
    {
        private static KhoiDAL instance;
        private KhoiDAL() { }
        public static KhoiDAL Instance
        {
            get { if (instance == null) instance = new KhoiDAL(); return KhoiDAL.instance; }
            private set { KhoiDAL.instance = value; }
        }
        public List<Khoi> GetKhoi()
        {
            List<Khoi> list = new List<Khoi>();
            string query = string.Format("SELECT * FROM KHOILOP");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Khoi khoi = new Khoi(item);
                list.Add(khoi);
            }

            return list;
        }

    }
}
