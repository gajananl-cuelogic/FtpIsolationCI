using FtpWebApplication.FtpUserIsolationService;
using MicroServices.FtpUserIsolation.FtpUserIsolationService.Data;
using MicroServices.FtpUserIsolation.FtpUserIsolationService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using FtpWebApplication;

namespace FtpWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceTesting objServiceTesting = new ServiceTesting();
            ClassFtpUserIsolation objClassFtpUserIsolation = new ClassFtpUserIsolation();

            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";



            //hosting a wcf service on IIS and adding a serviced reference we can create ftp folders as well as ftp users.
            objServiceTesting.TestServiceUsingServiceReference(objClassFtpUserIsolation);

            ////hosting a wcf service as windows servie and using it with WebClient we can create ftp folders as well as ftp users.           
            //string url = "http://192.168.10.218:8181/FtpUserIsolationServicewebHttpBinding/SetNewFtpUser";
            //objServiceTesting.TestServiceUsingWebClient(url, objClassFtpUserIsolation);

            //Using Channel Factory
            //string iP = "192.168.10.218";
            //string strBinding = "HTTP";
            //int port = 8181;
            //string method = "SetNewFtpUser";
            //string address = "FtpUserIsolationServicebasicHttpBinding";
            //objServiceTesting.TestServiceUsingChannelFactory(iP, strBinding, port, method, address, objClassFtpUserIsolation);      



            // using (var client = new WebClient())
            //{
            //    client.Headers[HttpRequestHeader.ContentType] = "application/json";
            //    //result = client.UploadString("http://192.168.10.218:8088/HackathonService.svc/IsDeviceRegistered", "POST", JsonConvert.SerializeObject(device));
            //    result = client.UploadString("http://192.168.10.218:8088/HackathonService.svc/TestRequestPOSTWithParameter", "POST", JsonConvert.SerializeObject(device));
            //}
            //Console.WriteLine(result);
        }

    }
    
}