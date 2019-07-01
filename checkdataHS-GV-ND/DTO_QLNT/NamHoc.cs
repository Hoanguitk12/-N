using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class NamHoc
    {
        public NamHoc(DataRow row)
        {
            this.MaNamHoc = (int)row["MANAMHOC"];
            this.NamBD = (int)row["NAMBD"];
            this.NamKT = (int)row["NAMKT"];
            this.NamBDKT = row["NAMBDKT"].ToString();
        } 

        public NamHoc(int manamhoc,int nambd,int namkt, string nambdkt)
        {
            this.MaNamHoc = manamhoc;
            this.NamBD = nambd;
            this.NamKT = namkt;
            this.NamBDKT = nambdkt;

        }

        private int maNamHoc;

        public int MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }

        private int namBD;

        public int NamBD
        {
            get { return namBD; }
            set { namBD = value; }
        }

        private int namKT;

        public int NamKT
        {
            get { return namKT; }
            set { namKT = value; }
        }

        private string namBDKT;

        public string NamBDKT
        {
            get { return namBDKT; }
            set { namBDKT = value; }
        }


    }
}
