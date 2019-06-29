using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class LopBUS
    {
        private static LopBUS instance;

        public static LopBUS Instance
        {
            get { if (instance == null) instance = new LopBUS(); return LopBUS.instance; }
            private set { LopBUS.instance = value; }
        }

        private LopBUS() { }


        public List<Lop> GetLopByMaNamHoc(int manamhoc)
        {
            return LopDAL.Instance.GetLopByMaNamHoc(manamhoc);
        }

    }
}
