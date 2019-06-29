using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
   public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        public static GiaoVienBUS Instance
        {
            get { if (instance == null) instance = new GiaoVienBUS(); return GiaoVienBUS.instance; }
            private set { GiaoVienBUS.instance = value; }
        }

        public List<DTO_QLNT.GiaoVien> GetLiistGiaoVien()
        {
            return DAL_QLNT.GiaoVien.Instance.GetLiistGiaoVien();
        }



        public DTO_QLNT.GiaoVien GetGiaoVien()
        {
            return DAL_QLNT.GiaoVien.Instance.GetGiaoVien();
        }
        public DTO_QLNT.GiaoVien GetGiaoVienByMaGV(int maGV)
        {
            return DAL_QLNT.GiaoVien.Instance.GetGiaoVienByMaGV(maGV);
        }
        public bool ThemGiaoVien( string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            bool kq = DAL_QLNT.GiaoVien.Instance.ThemGiaoVien(hoTen, gioiTinh, ngaySinh ,  danToc,  diaChi,  sdt,  trinhDo, ngayVaoLam, tonGiao);
            return kq;
        }

        public bool SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam,int maLop, string tonGiao)
        {
            bool kq = DAL_QLNT.GiaoVien.Instance.SuaGiaoVien( maGiaoVien,  hoTen,  gioiTinh,  ngaySinh,  danToc, diaChi,  sdt,  trinhDo,  ngayVaoLam, maLop, tonGiao);
            return kq;
        }

        public bool XoaGiaoVien(int maGv)
        {
            bool kq = DAL_QLNT.GiaoVien.Instance.XoaGiaoVien(maGv);
            return kq;
        }
    }
}
