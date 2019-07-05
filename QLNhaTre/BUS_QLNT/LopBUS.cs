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
        public DataTable GetLop()
        {
            return LopDAL.Instance.GetLop();
        }
        public Lop GetLopbyMaLop(int maLop)
        {
            return LopDAL.Instance.GetLopbyMaLop(maLop);
        }
        public bool ThemLop(string tenLop, string maKhoi, string maNH)
        {
            bool kq = LopDAL.Instance.ThemLop(tenLop, maKhoi, maNH);
            return kq;
        }
        public bool SuaLop(string maLop, string tenLop, string maKhoi, string maNH)
        {
            bool kq = LopDAL.Instance.SuaLop(maLop, tenLop, maKhoi, maNH);
            return kq;
        }
        public bool XoaLop(string maLop)
        {
            bool kq = LopDAL.Instance.XoaLop(maLop);
            return kq;
        }

    }
}
