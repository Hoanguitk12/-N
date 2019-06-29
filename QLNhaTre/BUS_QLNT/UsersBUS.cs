using DTO_QLNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNT;
namespace BUS_QLNT
{
   public class UsersBUS
    {
        private static UsersBUS instance;

        public static UsersBUS Instance
        {
            get { if (instance == null) instance = new UsersBUS(); return UsersBUS.instance; }
            private set { UsersBUS.instance = value; }
        }

        public List<UsersDTO> GetListUsers()
        {
            return UsersDAL.Instance.GetListUsers();
        }
        public UsersDTO GetUsers()
        {
            return UsersDAL.Instance.GetUsers();
        }
        public UsersDTO GetUsersById(int id)
        {
            return UsersDAL.Instance.GetUsersById(id);
        }
        public bool ThemUsers(string taiKhoan, string matKhau, string ten, string quyen)
        {
            bool kq = UsersDAL.Instance.ThemUsers(taiKhoan, matKhau, ten, quyen);
            return kq;
        }
        public bool SuaUsers(int id, string taiKhoan, string matKhau, string ten, string quyen)
        {
            bool kq = UsersDAL.Instance.SuaUsers(id, taiKhoan, matKhau, ten, quyen);
            return kq;
        }
        public bool XoaUsers(int id)

        {
            bool kq = UsersDAL.Instance.XoaUsers(id);
            return kq;
        }
    }
}
