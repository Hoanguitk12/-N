using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class NamHocBUS
    {
        private static NamHocBUS instance;

        private NamHocBUS() { }

        public static NamHocBUS Instance
        {
            get { if (instance == null) instance = new NamHocBUS(); return NamHocBUS.instance; }
            private set { NamHocBUS.instance = value; }
        }


        public List<NamHoc> GetNamHoc()
        {
            return NamHocDAL.Instance.GetNamHoc();
        }
        public NamHoc GetNamHocByMaNH(int maNH)
        {
            return NamHocDAL.Instance.GetNamHocByMaNH(maNH);
        }
        public bool ThemNamHoc(string NamBD, string NamKT)
        {
            bool kq = NamHocDAL.Instance.ThemNamHoc(NamBD, NamKT);
            return kq;
        }
        public bool SuaNamHoc(int MaNH, string NamBD, string NamKT)
        {
            bool kq = NamHocDAL.Instance.SuaNamHoc(MaNH, NamBD, NamKT);
            return kq;
        }
        public bool XoaNamHoc(int MaNH)
        {
            bool kq = NamHocDAL.Instance.XoaNamHoc(MaNH);
            return kq;
        }

    }
}
