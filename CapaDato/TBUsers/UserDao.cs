using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CapaDato.TBUsers
{
  public class UserDao : ConnectionToSql
    {
    
        public bool Login(string user , string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command =  new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader =  command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.IdUser = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                            UserCache.FirstName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }


        public string recoverPassowrd(string userRequesting) 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select *from Users where LoginName=@user or Email=@mail";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@user",userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mainService = new MailServices.SystemSupportMail();
                        mainService.sendMail(
                             subject:"SYSTEM: password recovery request",
                             body:"Hi "+userName+" \nYou Requested to recover your password.\n"+
                             "your current password is: "+ accountPassword +
                             "\nHowever, we ask that you change password inmediately once you enter the system.",
                             recipientMail:  new List<string> { userMail}
                            );

                        return "Hi, " + userName + "\nYou Requested to recover your password.\n" +
                         "Please check your mail: " + userMail +
                         "\nHowever, we ask that you change your password inmediately once you enter the systam";

                    }
                    else
                    {
                        return "Sorry, you do not have an account with tha mail or userName";
                    }
                }

            }
        
        }

        public void AnyMethod()
        {
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
