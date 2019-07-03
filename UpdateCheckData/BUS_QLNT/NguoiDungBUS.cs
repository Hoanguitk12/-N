using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
namespace BUS_QLNT
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;

        public static NguoiDungBUS Instance
        {
            get { if (instance == null) instance = new NguoiDungBUS(); return NguoiDungBUS.instance; }
            private set { NguoiDungBUS.instance = value; }
        }

        public List<NguoiDung> GetListUsers()
        {
            return NguoiDungDAL.Instance.GetListUsers();
        }
        public NguoiDung GetUsers()
        {
            return NguoiDungDAL.Instance.GetUsers();
        }
        public NguoiDung GetUsersById(int id)
        {
            return NguoiDungDAL.Instance.GetUsersById(id);
        }
        public bool ThemUsers(string taiKhoan, string matKhau, int maGV, string quyen)
        {
            bool kq = NguoiDungDAL.Instance.ThemUsers(taiKhoan, matKhau, maGV, quyen);
            return kq;
        }
        public bool SuaUsers(int id, string taiKhoan, string matKhau, int maGV, string quyen)
        {
            bool kq = NguoiDungDAL.Instance.SuaUsers(id, taiKhoan, matKhau, maGV, quyen);
            return kq;
        }
        public bool XoaUsers(int id)
        {
            bool kq = NguoiDungDAL.Instance.XoaUsers(id);
            return kq;
        }
        public bool Check(string taikhoan)
        {
            bool kq = NguoiDungDAL.Instance.Check(taikhoan);
            return kq;
        }
        
    }
}
