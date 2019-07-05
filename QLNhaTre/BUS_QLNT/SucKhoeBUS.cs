using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class SucKhoeBUS
    {
        private static SucKhoeBUS instance;

        public static SucKhoeBUS Instance
        {
            get { if (instance == null) instance = new SucKhoeBUS(); return SucKhoeBUS.instance; }
            private set { SucKhoeBUS.instance = value; }
        }

        private SucKhoeBUS() { }

        public DataTable GetSucKhoe(int malop, int thangdo)
        {
            return SucKhoeDAL.Instance.GetSucKhoe(malop, thangdo);
        }

        public bool ThemSucKhoe(int mahs, int thangdo, float chieucao, string dgcc, float cannang, string dgcn, string dgc)
        {
            return SucKhoeDAL.Instance.ThemSucKhoe(mahs, thangdo, chieucao, dgcc, cannang, dgcn, dgc);
        }

        public bool SuaSucKhoe(int mask, float chieucao, string dgcc, float cannang, string dgcn, string dgc)
        {
            return SucKhoeDAL.Instance.SuaSucKhoe(mask, chieucao, dgcc, cannang, dgcn, dgc);
        }
    }
}
