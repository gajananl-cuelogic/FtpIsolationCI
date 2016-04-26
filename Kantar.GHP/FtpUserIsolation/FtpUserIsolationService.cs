using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MicroServices.FtpUserIsolation.FtpUserIsolationService.Data;

namespace MicroServices.FtpUserIsolation.FtpUserIsolationService
{
    public class FtpUserIsolationService : IFtpUserIsolationService
    {

        public string SetNewFtpUser(ClassFtpUserIsolation UserDetails)
        {
            try
            {
               if (UserDetails.UserName != null && UserDetails.UserName != "" && UserDetails.Password != null && UserDetails.Password != "" && UserDetails.FolderName != null && UserDetails.FolderName != "" && UserDetails.RootFolderPath != null && UserDetails.RootFolderPath != "")
                 {
                    CreateUser(UserDetails);
                    CreateFolder(UserDetails);
                 }
                  else
                 {
                    return "Failled";
                 }
            }
            catch (Exception ex)
            {
                return "Failled";
            }
            return "Success";
        }

        public string CreateUser(ClassFtpUserIsolation UserDetails)
        {

            try
            {
                if (UserDetails.UserName != null && UserDetails.UserName != "" && UserDetails.Password != null && UserDetails.Password != "")
                {
                    var ad1 = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry NewUser = ad1.Children.Add(UserDetails.UserName, "user");

                    bool IsUserExist = false;
                    try
                    {
                        if ((ad1.Children.Find(UserDetails.UserName)) != null && (ad1.Children.Find(UserDetails.UserName)).SchemaClassName == "User")
                        {
                            IsUserExist = true;
                        }
                    }
                    catch (Exception e)
                    {
                        IsUserExist = false;
                    }

                    if (!IsUserExist)
                    {
                        NewUser.Invoke("Put", new object[] { "Description", "Test User from .NET" });
                        object obRet = NewUser.Invoke("SetPassword", UserDetails.Password);
                        NewUser.CommitChanges();
                    }
                }

            }

            catch (Exception e)
            {
                return "Failled";
            }
            return "Success";
        }
              

        public string CreateFolder(ClassFtpUserIsolation UserDetails)
        {

            try
            {
                if (UserDetails.FolderName != null && UserDetails.FolderName != "" && UserDetails.RootFolderPath != null && UserDetails.RootFolderPath != "")
                {
                    string RootFolderPathOriginal = UserDetails.RootFolderPath.Replace(@"&", @"\") + "\\" + UserDetails.FolderName;

                    if (!Directory.Exists(RootFolderPathOriginal))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(RootFolderPathOriginal);
                    }
                }
            }
            catch (Exception ex)
            {
                return "Failled";
            }
            return "Success";

        }

        #region Test Purpose

        public string TestRequestGETJson()
        {
            return "TestRequestGETJson";
        }

        public string TestRequestGETXml()
        {
            return "TestRequestGETXml";
        }

        public string TestRequestPOSTJson()
        {
            return "TestRequestPOSTJson";
        }

        public string TestRequestPOSTXml()
        {
            return "TestRequestPOSTXml";
        }

        public string TestRequestGETWithStringParamiterJson(string TestStringParamiter1, string TestStringParamiter2)
        {
            return TestStringParamiter1 + " " + TestStringParamiter2;
        }

        public string TestRequestPOSTWithObjectParamiterJson(ClassFtpUserIsolation TestObjParamiter)
        {
            return TestObjParamiter.ToString();
        }

        public string TestRequestPOSTWithObjectParamiterXml(ClassFtpUserIsolation TestObjParamiter)
        {
            return TestObjParamiter.ToString();
        }







        #endregion
    }
}
