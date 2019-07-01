using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class HocSinh
    {


        public HocSinh(int mahs,string hoten, string gioitinh, DateTime ngaysinh, int malop, DateTime ngayvaohoc,string diachi,string hotencha, string sdtcha,string hotenme,string sdtme)
        {
            this.MaHS = mahs;
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.MaLop = malop;
            this.NgayVaoHoc = ngayvaohoc;
            this.DiaChi = diachi;
            this.HoTenCha = hotencha;
            this.SdtCha = sdtcha;
            this.HoTenMe = hotenme;
            this.SdtMe = sdtme;
        }
        public HocSinh(DataRow row)
        {
            this.MaHS = (int)row["MAHS"];
            this.HoTen = row["HOTEN"].ToString();
            this.GioiTinh = row["GIOITINH"].ToString();
            this.NgaySinh = (DateTime)row["NGAYSINH"];
            this.MaLop = (int)row["MALOP"];
            this.ngayVaoHoc = (DateTime)row["NGAYVAOHOC"];
            this.DiaChi = row["DIACHI"].ToString();
            this.HoTenCha = row["HOTENCHA"].ToString();
            this.sdtCha = row["SDTCHA"].ToString();
            this.HoTenMe = row["HOTENME"].ToString();
            this.SdtMe = row["SDTME"].ToString();
        }



        private int maHS;

        public int MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }

        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }



        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }


        private int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }


        private DateTime ngayVaoHoc;

        public DateTime NgayVaoHoc
        {
            get { return ngayVaoHoc; }
            set { ngayVaoHoc = value; }
        }


        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string hoTenCha;

        public string HoTenCha
        {
            get { return hoTenCha; }
            set { hoTenCha = value; }
        }

        private string sdtCha;

        public string SdtCha
        {
            get { return sdtCha; }
            set { sdtCha = value; }
        }

        private string hoTenMe;

        public string HoTenMe
        {
            get { return hoTenMe; }
            set { hoTenMe = value; }
        }

        private string sdtMe;

        public string SdtMe
        {
            get { return sdtMe; }
            set { sdtMe = value; }
        }
    }
}
