using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class NguoiDung
    {
        public NguoiDung(int id, string taiKhoan, string quyen, int maGV)
        {
            this.Id = id;
            this.TaiKhoan = taiKhoan;
            this.MaGV = maGV;
            this.Quyen = quyen;
        }

        public NguoiDung(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.TaiKhoan = row["TAIKHOAN"].ToString();
            this.MaGV = (int)row["MAGV"];
            this.quyen = row["QUYEN"].ToString();
        }


        private int id;
        private string taiKhoan;
        private int maGV;
        private string quyen;


        public int Id { get => id; set => id = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public int MaGV { get => maGV; set => maGV = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }
}
