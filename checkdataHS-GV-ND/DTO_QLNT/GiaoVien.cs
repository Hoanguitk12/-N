using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class GiaoVien
    {
        public GiaoVien(int maGiaoVien, string hoTen, string gioiTinh, DateTime ngaySinh, string danToc, string diaChi, string sdt, string trinhDo, string tonGiao, DateTime ngayVaoLam, int maLop)

        {
            this.MaGiaoVien = maGiaoVien;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DanToc = danToc;
            this.TonGiao = tonGiao;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.TrinhDo = trinhDo;
            this.NgayVaoLam = ngayVaoLam;
            this.MaLop = maLop;
            

        }
        public GiaoVien(DataRow row)
        {
            this.MaGiaoVien = (int)row["MAGV"];
            this.HoTen = row["HOTEN"].ToString();
            this.GioiTinh = row["GIOITINH"].ToString();
            this.NgaySinh = (DateTime)row["NGAYSINH"];
            this.DanToc = row["DANTOC"].ToString();
            this.TonGiao = row["TONGIAO"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.Sdt = row["SDT"].ToString();
            this.TrinhDo = row["TRINHDO"].ToString();
            this.NgayVaoLam = (DateTime)row["NGAYVAOLAM"];
            
        }
        private int maGiaoVien;
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string danToc;
        private string tonGiao;
        private string diaChi;
        private string sdt;
        private string trinhDo;
        private DateTime ngayVaoLam;
        private int maLop;
        

        public int MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string TonGiao { get => tonGiao; set => tonGiao = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public int MaLop { get => maLop; set => maLop = value; }
        
    }
}
