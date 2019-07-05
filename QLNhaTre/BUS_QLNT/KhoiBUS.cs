using DAL_QLNT;
using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNT
{
   public class KhoiBUS
    {
        private static KhoiBUS instance;
        private KhoiBUS() { }
        public static KhoiBUS Instance
        {
            get { if (instance == null) instance = new KhoiBUS(); return KhoiBUS.instance; }
            private set { KhoiBUS.instance = value; }
        }
        public List<Khoi> GetKhoi()
        {
            return KhoiDAL.Instance.GetKhoi();
        }
        public DataTable GetKhoitodgv()
        {
            return KhoiDAL.Instance.GetKhoitodgv();
        }
        public bool SuaKhoi(int makhoi, int sstd)
        {
            return KhoiDAL.Instance.SuaKhoi(makhoi, sstd);
        }
        public DataTable GetKhoiByMaKhoi(int maKhoi)
        {
            return KhoiDAL.Instance.GetKhoiByMaKhoi(maKhoi);
        }

    }
}
