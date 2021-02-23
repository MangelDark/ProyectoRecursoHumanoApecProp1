using CapaDato.TBUsers;
using Common;
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

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassowrd(userRequesting);
        }
        public void AnyMethod()
        {
            //Security and Permision 
            if (UserCache.Position == Positions.Administrator)
            {
                //Codes
            }
            if (UserCache.Position == Positions.Receptionist || UserCache.Position == Positions.Accounting)
            {
                //Codes
            }
        }
    }
}
