using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNT;

namespace DAL_QLNT
{
    public class HocSinhDAL
    {
        private static HocSinhDAL instance;

        public static HocSinhDAL Instance
        {
            get { if (instance == null) instance = new HocSinhDAL(); return HocSinhDAL.instance; }
            private set { HocSinhDAL.instance = value; }
        }

        private HocSinhDAL() { }


        public List<HocSinh> GetHocSinhByMaLop(int malop)
        {
            List<HocSinh> list = new List<HocSinh>();
            string query = string.Format("SELECT * FROM HOCSINH WHERE MALOP={0} ORDER BY HOTEN", malop);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                HocSinh hocSinh = new HocSinh(item);
                list.Add(hocSinh);
            }
            return list;
        }

        public DataTable GetHocSinh(int malop)
        {
            string query = string.Format("SELECT MAHS,HOTEN,GIOITINH,NGAYSINH FROM HOCSINH WHERE MALOP={0} ORDER BY HOTEN", malop);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetHocSinhByKeyWord(string keyword)
        {
            string query = string.Empty;
            query += " SELECT HOTEN, GIOITINH, NGAYSINH, LOP.TENLOP, KHOILOP.TENKHOI, NAMHOC.NAMBDKT, NGAYVAOHOC, DIACHI, HOTENCHA, SDTCHA, HOTENME, SDTME ";
            query += " FROM HOCSINH, LOP, NAMHOC, KHOILOP";
            query += string.Format(" WHERE HOCSINH.MALOP=LOP.MALOP AND LOP.MAKHOI= KHOILOP.MAKHOI AND LOP.MANAMHOC=NAMHOC.MANAMHOC AND (HOTEN LIKE CONCAT('%',N'{0}','%'))",keyword);
            
           
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }


        public HocSinh GetHocSinhByMaHS(int mahs)
        {
            string query = string.Format("SELECT * FROM HOCSINH WHERE MAHS={0}", mahs);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            HocSinh hs = new HocSinh(dt.Rows[0]);
            return hs;
        }

        public bool ThemHocSinh(string ten,string gioitinh,string ngaysinh,int malop,string ngayvaohoc,string diachi,string tencha,string sdtcha,string tenme, string sdtme)
        {
            int kq = 0;
            string query = string.Format("INSERT INTO HOCSINH VALUES (N'{0}',N'{1}','{2}',{3},'{4}',N'{5}',N'{6}','{7}',N'{8}','{9}')", ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool SuaHocSinh(int mahs,string ten, string gioitinh, string ngaysinh, int malop, string ngayvaohoc, string diachi, string tencha, string sdtcha, string tenme, string sdtme)
        {
            int kq = 0;
            string query = string.Format("UPDATE HOCSINH SET HOTEN = N'{0}', GIOITINH = N'{1}', NGAYSINH = '{2}', MALOP = {3}, NGAYVAOHOC = '{4}', DIACHI = N'{5}', HOTENCHA = N'{6}', SDTCHA = '{7}', HOTENME = N'{8}', SDTME = '{9}' WHERE MAHS = {10} ", ten, gioitinh, ngaysinh, malop, ngayvaohoc, diachi, tencha, sdtcha, tenme, sdtme, mahs);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }

        public bool XoaHocSinh(int mahs)
        {
            int kq = 0;
            string query = string.Format("DELETE FROM HOCSINH WHERE MAHS={0}", mahs);
            kq = DataProvider.Instance.ExecuteNonQuery(query);
            return kq > 0;
        }
    }
}
