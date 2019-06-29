using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
   public class UsersDTO
    {
       public UsersDTO(int id,string taiKhoan,string matKhau,string ten,string quyen,int maGV)
        {
            this.Id = id;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.Ten = ten;
            this.Quyen = quyen;
            this.MaGV = maGV;

        }

        public UsersDTO(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.TaiKhoan = row["TAIKHOAN"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
            this.Ten = row["TEN"].ToString();
            this.quyen = row["QUYEN"].ToString();
            //this.MaGV = (int)row["MAGV"];
        }
        private int id;
        private string taiKhoan;
        private string matKhau;
        private string ten;
        private int maGV;
        private string quyen;


        public int Id { get => id; set => id = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Ten { get => ten; set => ten = value; }
     
        public string Quyen { get => quyen; set => quyen = value; }
        public int MaGV { get => maGV; set => maGV = value; }
    }
}
