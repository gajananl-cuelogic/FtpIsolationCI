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


namespace FtpWebApplication
{
    public class ServiceTesting
    {

        public string TestServiceUsingServiceReference( ClassFtpUserIsolation objClassFtpUserIsolation)
        {
            string ReturnOutPut = string.Empty;
            FtpUserIsolationService.FtpUserIsolationServiceClient objFtpUserIsolationServiceClient = new FtpUserIsolationService.FtpUserIsolationServiceClient("BasicHttpBinding_IFtpUserIsolationService");
            ReturnOutPut = objFtpUserIsolationServiceClient.SetNewFtpUser(objClassFtpUserIsolation);          
            return ReturnOutPut;

        }

        public string TestServiceUsingWebClient(string url, ClassFtpUserIsolation objClassFtpUserIsolation)
        {
            string ReturnOutPut = string.Empty;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                ReturnOutPut = client.UploadString(url, "POST", JsonConvert.SerializeObject(objClassFtpUserIsolation));

            }

            return ReturnOutPut;

        }

        public string TestServiceUsingChannelFactory(string strServer, string strBinding, int nPort, string strOper, string address, ClassFtpUserIsolation objClassFtpUserIsolation)
        {
            ////Reference:http://www.codeproject.com/Articles/642444/Creating-and-consuming-a-simple-WCF-Service-withou  
            string dblResult = "";
            ChannelFactory<IFtpUserIsolationService> channelFactory = null;
            EndpointAddress ep = null;

            string strEPAdr = "http://" + strServer +
                   ":" + nPort.ToString() + "/" + address;
            try
            {
                switch (strBinding)
                {
                    case "TCP":
                        NetTcpBinding tcpb = new NetTcpBinding();
                        channelFactory = new ChannelFactory<IFtpUserIsolationService>(tcpb);

                        // End Point Address
                        strEPAdr = "net.tcp://" + strServer + ":" +
                                     nPort.ToString() + "/" + address;
                        break;

                    case "HTTP":
                        BasicHttpBinding httpb = new BasicHttpBinding();
                        channelFactory = new ChannelFactory<IFtpUserIsolationService>(httpb);

                        // End Point Address
                        strEPAdr = "http://" + strServer + ":" +
                                  nPort.ToString() + "/" + address;
                        break;
                    case "WebHTTP":
                        WebHttpBinding WebHTTP = new WebHttpBinding();
                        channelFactory = new ChannelFactory<IFtpUserIsolationService>(WebHTTP);

                        // End Point Address
                        strEPAdr = "http://" + strServer + ":" +
                                  nPort.ToString() + "/" + address;
                        break;
                }

                // Create End Point
                ep = new EndpointAddress(strEPAdr);

                // Create Channel
                IFtpUserIsolationService objIFtpUserIsolationService = channelFactory.CreateChannel(ep);


                // Call Methods
                switch (strOper)
                {
                    case "TestRequest": dblResult = objIFtpUserIsolationService.TestRequestGETJson(); break;
                    case "CreateFolder": dblResult = objIFtpUserIsolationService.CreateFolder(objClassFtpUserIsolation); break;
                    case "SetNewFtpUser": dblResult = objIFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation); break;

                }
                channelFactory.Close();
            }
            catch (Exception eX)
            {

                dblResult = Convert.ToString(eX.InnerException);
            }
            return dblResult;
        }
    }
}