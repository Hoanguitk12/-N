using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class GiaoVienDAL
    {
        private static GiaoVienDAL instance;
        public static GiaoVienDAL Instance
        {
            get { if (instance == null) instance = new GiaoVienDAL(); return GiaoVienDAL.instance; }
            private set { GiaoVienDAL.instance = value; }
        }
        private GiaoVienDAL() { }


        public List<GiaoVien> GetListGiaoVien()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = string.Format("SELECT * FROM GIAOVIEN ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                GiaoVien giaovien = new GiaoVien(item);
                list.Add(giaovien);
            }
            return list;
        }
        
        public DataTable GetGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIEN ORDER BY HOTEN";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public DataTable GetGiaoVien(string query)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }


        public GiaoVien GetGiaoVienByMaGV(int maGV)
        {
            string query = string.Format("SELECT MAGV,HOTEN,GIOITINH,NGAYSINH,DANTOC,TONGIAO,DIACHI,SDT,TRINHDO,NGAYVAOLAM FROM GIAOVIEN WHERE MAGV={0}", maGV);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            GiaoVien gv = new GiaoVien(dt.Rows[0]);
            return gv;
        }
        public bool ThemGiaoVien(string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            int kq = 0;

            string query = string.Format("INSERT INTO GIAOVIEN(HOTEN,GIOITINH,NGAYSINH,DANTOC,DIACHI,SDT,TRINHDO,NGAYVAOLAM,TONGIAO) VALUES (N'{0}',N'{1}','{2}',N'{3}',N'{4}','{5}',N'{6}','{7}',N'{8}')", hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            int kq = 0;
            string query = string.Format("UPDATE GIAOVIEN SET HOTEN = N'{0}', GIOITINH = N'{1}', NGAYSINH = '{2}', DANTOC = N'{3}', DIACHI = N'{4}', SDT = N'{5}', TRINHDO = N'{6}', NGAYVAOLAM= N'{7}', TONGIAO = N'{8}' WHERE MAGV = {9}", hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao, maGiaoVien);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool XoaGiaoVien(int maGiaoVien)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM GIAOVIEN WHERE MAGV={0}", maGiaoVien);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool PhanCongGiaoVien(int maGiaoVien,int malop)
        {
            int kq = 0;
            string query = string.Format("UPDATE GIAOVIEN SET MALOP = {0} WHERE MAGV={1}",malop ,maGiaoVien);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
    }
}
