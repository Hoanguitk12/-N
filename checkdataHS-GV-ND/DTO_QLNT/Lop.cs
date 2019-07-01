using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DTO_QLNT
{
    public class Lop
    {
        public Lop(DataRow row)
        {
            this.MaLop = (int)row["MALOP"];
            this.TenLop = row["TENLOP"].ToString();
            this.MaKhoi = (int)row["MAKHOI"];
            this.MaNamHoc = (int)row["MANAMHOC"];
        }
        public Lop(int malop, string tenlop, int makhoi, int manamhoc)
        {
            this.MaLop = malop;
            this.TenLop = tenlop;
            this.MaKhoi = makhoi;
            this.MaNamHoc = manamhoc;
        }

        private int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        private string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        private int maKhoi;

        public int MaKhoi
        {
            get { return maKhoi; }
            set { maKhoi = value; }
        }


        private int maNamHoc;

        public int MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }


    }
}
