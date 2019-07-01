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

        
    }
}
