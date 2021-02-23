using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.MailServices
{
    class SystemSupportMail : MasterMailServices
    {
         public SystemSupportMail()
        {
            senderMail = "suporteapi19@gmail.com";
            password = "Sa192307@.";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InitialiserSmtpClient();
        }

    }
}
