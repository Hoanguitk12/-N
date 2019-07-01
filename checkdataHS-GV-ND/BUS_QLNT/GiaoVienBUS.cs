using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;
using DAL_QLNT;
using System.Data;

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

        public List<GiaoVien> GetListGiaoVien()
        {
            return GiaoVienDAL.Instance.GetListGiaoVien();
        }

        public DataTable GetGiaoVien()
        {
            return GiaoVienDAL.Instance.GetGiaoVien();
        }

        public DataTable GetGiaoVien(string query)
        {
            return GiaoVienDAL.Instance.GetGiaoVien(query);
        }

        public GiaoVien GetGiaoVienByMaGV(int maGV)
        {
            return GiaoVienDAL.Instance.GetGiaoVienByMaGV(maGV);
        }
        public bool ThemGiaoVien(string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            bool kq = GiaoVienDAL.Instance.ThemGiaoVien(hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao);
            return kq;
        }

        public bool SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            bool kq = GiaoVienDAL.Instance.SuaGiaoVien(maGiaoVien, hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao);
            return kq;
        }

        public bool XoaGiaoVien(int maGv)
        {
            bool kq = GiaoVienDAL.Instance.XoaGiaoVien(maGv);
            return kq;
        }

        public bool PhanCongGiaoVien(int magv,int malop)
        {
            bool kq = GiaoVienDAL.Instance.PhanCongGiaoVien(magv,malop);
            return kq;
        }
    }
}
