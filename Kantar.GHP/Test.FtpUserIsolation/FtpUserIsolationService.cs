using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MicroServices.FtpUserIsolation.FtpUserIsolationService;
using MicroServices.FtpUserIsolation.FtpUserIsolationService.Data;

namespace Test.FtpUserIsolation
{

    [TestClass]
    public class SetNewFtpUserInputsUnitTests
    {
        FtpUserIsolationService objFtpUserIsolationService = new FtpUserIsolationService();
        ClassFtpUserIsolation objClassFtpUserIsolation = new ClassFtpUserIsolation();        
        [TestMethod]
        public void SetNewFtpUserInputsCorrect()
        {
            string returnOutPutForInputsCorrect = string.Empty;
            string expectedOutPutInputsCorrect = "Success";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForInputsCorrect=objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutInputsCorrect, returnOutPutForInputsCorrect);
        }
        [TestMethod]
        public void SetNewFtpUserInputsNull()
        {
            string returnOutPutForUserNameNull = string.Empty;
            string expectedOutPutForUserNameNull = "Failled";
            objClassFtpUserIsolation.UserName = null;
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForUserNameNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForUserNameNull,returnOutPutForUserNameNull, "Usersame can not be null");

            string returnOutPutForPasswordNull = string.Empty;
            string expectedOutPutForPasswordNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForPasswordNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForPasswordNull,returnOutPutForPasswordNull, "Password can not be null");

            string returnOutPutForFolderNameNull = string.Empty;
            string expectedOutPutForFolderNameNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForFolderNameNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForFolderNameNull, returnOutPutForFolderNameNull, "Folder Name can not be null");

            string returnOutPutForRootFolderPathOriginalNull = string.Empty;
            string expectedOutPutForRootFolderPathOriginalNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForRootFolderPathOriginalNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForRootFolderPathOriginalNull, returnOutPutForRootFolderPathOriginalNull, "Root Folder Path can not be null");
        }
        [TestMethod]
        public void SetNewFtpUserInputsEmpty()
        {
            string returnOutPutForUserNameEmpty = string.Empty;
            string expectedOutPutForUserNameEmpty = "Failled";
            objClassFtpUserIsolation.UserName = string.Empty;
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForUserNameEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForUserNameEmpty, returnOutPutForUserNameEmpty, "Usersame can not be Empty");

            string returnOutPutForPasswordEmpty = string.Empty;
            string expectedOutPutForPasswordEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = string.Empty;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForPasswordEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForPasswordEmpty, returnOutPutForPasswordEmpty, "Password can not be Empty");

            string returnOutPutForFolderNameEmpty = string.Empty;
            string expectedOutPutForFolderNameEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForFolderNameEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForFolderNameEmpty, returnOutPutForFolderNameEmpty, "Folder Name can not be Empty");

            string returnOutPutForRootFolderPathOriginalEmpty = string.Empty;
            string expectedOutPutForRootFolderPathOriginalEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForRootFolderPathOriginalEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForRootFolderPathOriginalEmpty, returnOutPutForRootFolderPathOriginalEmpty, "Root Folder Path can not be Empty");
        }

        [TestMethod]
        public void CreateUserInputsCorrect()
        {
            string returnOutPutForInputsCorrect = string.Empty;
            string expectedOutPutInputsCorrect = "Success";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForInputsCorrect = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutInputsCorrect, returnOutPutForInputsCorrect);
        }
        [TestMethod]
        public void CreateUserInputsNull()
        {
            string returnOutPutForUserNameNull = string.Empty;
            string expectedOutPutForUserNameNull = "Failled";
            objClassFtpUserIsolation.UserName = null;
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForUserNameNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(returnOutPutForUserNameNull, expectedOutPutForUserNameNull, "Usersame can not be null");

            string returnOutPutForPasswordNull = string.Empty;
            string expectedOutPutForPasswordNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForPasswordNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForPasswordNull, returnOutPutForPasswordNull, "Password can not be null");
        }
        [TestMethod]
        public void CreateUserInputsEmpty()
        {
            string returnOutPutForUserNameEmpty = string.Empty;
            string expectedOutPutForUserNameEmpty = "Failled";
            objClassFtpUserIsolation.UserName = string.Empty;
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForUserNameEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(returnOutPutForUserNameEmpty, expectedOutPutForUserNameEmpty, "Usersame can not be Empty");

            string returnOutPutForPasswordEmpty = string.Empty;
            string expectedOutPutForPasswordEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = string.Empty;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForPasswordEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForPasswordEmpty, returnOutPutForPasswordEmpty, "Password can not be Empty");
        }

        [TestMethod]
        public void CreateFolderInputsCorrect()
        {
            string returnOutPutForInputsCorrect = string.Empty;
            string expectedOutPutInputsCorrect = "Success";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            objClassFtpUserIsolation.FolderName = "FtpUser903";
            returnOutPutForInputsCorrect = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutInputsCorrect, returnOutPutForInputsCorrect);
        }
        [TestMethod]
        public void CreateFolderInputsNull()
        {
            string returnOutPutForFolderNameNull = string.Empty;
            string expectedOutPutForFolderNameNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForFolderNameNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForFolderNameNull, returnOutPutForFolderNameNull, "Folder Name can not be null");

            string returnOutPutForRootFolderPathOriginalNull = string.Empty;
            string expectedOutPutForRootFolderPathOriginalNull = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = null;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForRootFolderPathOriginalNull = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForRootFolderPathOriginalNull, returnOutPutForRootFolderPathOriginalNull, "Root Folder Path can not be null");

        }
        [TestMethod]
        public void CreateFolderInputsEmpty()
        {
            string returnOutPutForFolderNameEmpty = string.Empty;
            string expectedOutPutForFolderNameEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = string.Empty;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForFolderNameEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForFolderNameEmpty, returnOutPutForFolderNameEmpty, "Folder Name can not be Empty");

            string returnOutPutForRootFolderPathOriginalEmpty = string.Empty;
            string expectedOutPutForRootFolderPathOriginalEmpty = "Failled";
            objClassFtpUserIsolation.UserName = "FtpUser903";
            objClassFtpUserIsolation.Password = "12345678";
            objClassFtpUserIsolation.FolderName = string.Empty;
            objClassFtpUserIsolation.RootFolderPath = @"D:\TestFtpSite5\LocalUser";
            returnOutPutForRootFolderPathOriginalEmpty = objFtpUserIsolationService.SetNewFtpUser(objClassFtpUserIsolation);
            Assert.AreEqual(expectedOutPutForRootFolderPathOriginalEmpty, returnOutPutForRootFolderPathOriginalEmpty, "Root Folder Path can not be Empty");

        }
    }
}
