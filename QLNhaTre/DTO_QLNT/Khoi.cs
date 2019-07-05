using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class Khoi
    {
        public Khoi(int maKhoi,string tenKhoi,int sstd)
        {
            this.MaKhoi = maKhoi;
            this.TenKhoi = tenKhoi;
            this.Sstd = sstd;
        }
        public Khoi(DataRow row)
        {
            this.MaKhoi = (int)row["MAKHOI"];
            this.TenKhoi = row["TENKHOI"].ToString();
            this.Sstd = (int)row["SSTOIDA"];
        }
        private int maKhoi;
        private string tenKhoi;
        private int sstd;

        public int MaKhoi { get => maKhoi; set => maKhoi = value; }
        public string TenKhoi { get => tenKhoi; set => tenKhoi = value; }
        public int Sstd { get => sstd; set => sstd = value; }
    }
}
