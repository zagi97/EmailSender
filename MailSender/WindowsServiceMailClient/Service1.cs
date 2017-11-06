using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using MailSender2;
using System.Net.Mail;

namespace WindowsServiceMailClient
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            MailClient MailClient = new MailClient();
            MailClient.SendEmail("kruno.zagar@vsmti.hr", " proba", "Boook");
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
