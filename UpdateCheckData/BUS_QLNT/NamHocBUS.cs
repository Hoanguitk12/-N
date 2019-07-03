using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
using DTO_QLNT;

namespace BUS_QLNT
{
    public class NamHocBUS
    {
        private static NamHocBUS instance;

        private NamHocBUS() { }

        public static NamHocBUS Instance
        {
            get { if (instance == null) instance = new NamHocBUS(); return NamHocBUS.instance; }
            private set { NamHocBUS.instance = value; }
        }


        public List<NamHoc> GetNamHoc()
        {
            return NamHocDAL.Instance.GetNamHoc();
        }


    }
}
