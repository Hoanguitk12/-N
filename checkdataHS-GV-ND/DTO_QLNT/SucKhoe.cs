using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNT
{
    public class SucKhoe
    {


        public SucKhoe(int mask, int mahs, int malop, int thangdo, float chieucao, string dgcc, float cannang, string dgcn, string dgc)
        {
            this.MaSK = mask;
            this.MaHS = mahs;
            this.MaLop = malop;
            this.ThangDo = thangdo;
            this.ChieuCao = chieucao;
            this.DGCC = dgcc;
            this.CanNang = cannang;
            this.DGCN = dgcn;
            this.DGC = dgc;
        } 

        private int maSK;

        public int MaSK
        {
            get { return maSK; }
            set { maSK = value; }
        }

        private int maHS;

        public int MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }

        private int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }


        private int thangDo;

        public int ThangDo
        {
            get { return thangDo; }
            set { thangDo = value; }
        }

        private float chieuCao;

        public float ChieuCao
        {
            get { return chieuCao; }
            set { chieuCao = value; }
        }

        private string dGCC;

        public string DGCC
        {
            get { return dGCC; }
            set { dGCC = value; }
        }

        private float canNang;

        public float CanNang
        {
            get { return canNang; }
            set { canNang = value; }
        }

        private string dGCN;

        public string DGCN
        {
            get { return dGCN; }
            set { dGCN = value; }
        }

        private string dGC;

        public string DGC
        {
            get { return dGC; }
            set { dGC = value; }
        }

    }
}
