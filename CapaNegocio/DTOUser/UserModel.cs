using CapaDato.TBUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTOUser
{
   public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user,string pass)
        {
            return userDao.Login(user,pass);
        }
    }
}
