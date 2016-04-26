using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FtpUserIsolationWindowsHost
{
    public partial class FtpUserIsolationWindowsHost : ServiceBase
    {
        ServiceHost host;

        public FtpUserIsolationWindowsHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(MicroServices.FtpUserIsolation.FtpUserIsolationService.FtpUserIsolationService));
            host.Open();
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
