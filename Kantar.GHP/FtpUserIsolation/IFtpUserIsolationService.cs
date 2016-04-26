using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using MicroServices.FtpUserIsolation.FtpUserIsolationService.Data;
namespace MicroServices.FtpUserIsolation.FtpUserIsolationService
{
    [ServiceContract()]
    interface IFtpUserIsolationService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "SetNewFtpUser")]
        string SetNewFtpUser(ClassFtpUserIsolation UserDetails);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "CreateUser")]
        string CreateUser(ClassFtpUserIsolation UserDetails);
        
        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "CreateFolder")]
        string CreateFolder(ClassFtpUserIsolation UserDetails);




        #region Test Purpose

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "TestRequestPOSTJson")]
        string TestRequestPOSTJson();



        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "TestRequestPOSTWithObjectParamiterJson")]
        string TestRequestPOSTWithObjectParamiterJson(ClassFtpUserIsolation TestObjParamiter);

        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "TestRequestGETJson")]
        string TestRequestGETJson();


        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "TestRequestGETWithStringParamiterJson/{TestStringParamiter1}/{TestStringParamiter2}")]
        string TestRequestGETWithStringParamiterJson(string TestStringParamiter1, string TestStringParamiter2);

      

        [OperationContract]
        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Xml,
       ResponseFormat = WebMessageFormat.Xml,
       UriTemplate = "TestRequestPOSTXml")]
        string TestRequestPOSTXml();


       

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Xml,
         ResponseFormat = WebMessageFormat.Xml,
         UriTemplate = "TestRequestPOSTWithObjectParamiterXml")]
        string TestRequestPOSTWithObjectParamiterXml(ClassFtpUserIsolation TestObjParamiter);



        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Xml,
        ResponseFormat = WebMessageFormat.Xml,
        UriTemplate = "TestRequestGETXml")]
        string TestRequestGETXml();


     

     

        #endregion
        
    }
}
