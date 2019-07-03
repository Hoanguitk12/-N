using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;
namespace BUS_QLNT
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;

        private HocSinhBUS() {  } 

        public static HocSinhBUS Instance
        {
            get { if (instance == null) instance = new HocSinhBUS(); return HocSinhBUS.instance; }
            private set { HocSinhBUS.instance = value; }
        }

    


        public List<HocSinh> GetHocSinhByMaLop(int malop)
        {
            return HocSinhDAL.Instance.GetHocSinhByMaLop(malop);
        }

        public HocSinh GetHocSinhByMaHS(int mahs)
        {
            return HocSinhDAL.Instance.GetHocSinhByMaHS(mahs);
        }

        public DataTable GetHocSinh(int malop)
        {
            return HocSinhDAL.Instance.GetHocSinh(malop);
        }


        public bool ThemHocSinh(string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            bool kq = HocSinhDAL.Instance.ThemHocSinh(ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            return kq;
        }

        public bool SuaHocSinh(int mahs,string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            bool kq = HocSinhDAL.Instance.SuaHocSinh(mahs,ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            return kq;
        }

        public bool XoaHocSinh(int mahs)
        {
            bool kq = HocSinhDAL.Instance.XoaHocSinh(mahs);
            return kq;
        }
    }
}
