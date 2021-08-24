using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEmployeeTest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {


        string url = "http://localhost/EmployeeApp/";


        




        [TestMethod]
        public void TestMethod1()
        {
            //DriverContext.Driver = new FirefoxDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);

            OpenBrowser(BrowserType.FireFox);
            DriverContext.Browser.GoToUrl(url);

            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login("admin", "password");
            //EmployeePage
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();


        }
    }
}
