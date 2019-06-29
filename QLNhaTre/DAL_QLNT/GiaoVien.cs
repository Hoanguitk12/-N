using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;
using System.Data;

namespace DAL_QLNT
{
    public class GiaoVien
    {
        private static GiaoVien instance;
        public static GiaoVien Instance
        {
            get { if (instance == null) instance = new GiaoVien(); return GiaoVien.instance; }
            private set { GiaoVien.instance = value; }
        }
        private GiaoVien() { }
        public List<DTO_QLNT.GiaoVien> GetLiistGiaoVien()
        {
            List<DTO_QLNT.GiaoVien> list = new List<DTO_QLNT.GiaoVien>();
            string query = string.Format("SELECT * FROM GIAOVIEN ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                DTO_QLNT.GiaoVien giaovien = new DTO_QLNT.GiaoVien(item);
                list.Add(giaovien);
            }
            return list;
        }
        public DTO_QLNT.GiaoVien GetGiaoVien()
        
        {
            string query = string.Format("SELECT * FROM GIAOVIEN");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTO_QLNT.GiaoVien gv = new DTO_QLNT.GiaoVien(dt.Rows[0]);
            return gv;
        }
        public DTO_QLNT.GiaoVien GetGiaoVienByMaGV(int maGV)
        {
            string query = string.Format("SELECT * FROM GIAOVIEN WHERE MAGV={0}", maGV);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            DTO_QLNT.GiaoVien gv = new DTO_QLNT.GiaoVien(dt.Rows[0]);
            return gv;
        }
        public bool ThemGiaoVien( string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam, string tonGiao)
        {
            int kq = 0;
           
            string query = string.Format("INSERT INTO GIAOVIEN(HOTEN,GIOITINH,NGAYSINH,DANTOC,DIACHI,SDT,TRINHDO,NGAYVAOLAM,TONGIAO) VALUES (N'{0}',N'{1}','{2}','{3}',N'{4}',N'{5}',N'{6}','{7}',N'{8}')", hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, tonGiao);
            //string query = string.Format("INSERT INTO GIAOVIEN VALUES (N'{0}',N'{1}','{2}','{3}','{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}')", hoTen, gioiTinh, ngaySinh, danToc, diaChi, sdt, trinhDo, ngayVaoLam, maLop, tonGiao);

            kq = DataProvider.Instance.ExecuteNonQuery(query); 
            return kq > 0;
        }

        public bool SuaGiaoVien(int maGiaoVien, string hoTen, string gioiTinh, string ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string ngayVaoLam,int maLop, string tonGiao)
        {
            int kq = 0;
            string query = string.Format("UPDATE GIAOVIEN SET HOTEN = N'{0}', GIOITINH = '{1}', NGAYSINH = '{2}', DANTOC = '{3}', DIACHI = N'{4}', SDT = N'{5}', TRINHDO = '{6}', NGAYVAOLAM= N'{7}', MALOP= {8}, TONGIAO = '{9}' WHERE MAGV = {10}", hoTen, gioiTinh,  ngaySinh,  danToc,  diaChi,  sdt,  trinhDo,  ngayVaoLam, maLop, tonGiao, maGiaoVien );
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

    }
}

