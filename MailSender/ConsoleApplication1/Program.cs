using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender2;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient MailClient = new MailClient();
            MailClient.SendEmail("kruno.zagar@vsmti.hr", " proba", "Boook");
            Console.ReadKey();
        }
    }
}
