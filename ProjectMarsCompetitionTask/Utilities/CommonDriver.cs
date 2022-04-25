using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMarsCompetitionTask.Excel_Data_Reader;
using ProjectMarsCompetitionTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMarsCompetitionTask.Utilities
{
    public class CommonDriver
    {
       

        //ExtentTest test;
        //ExtentHtmlReporter htmlreporter;
        public static IWebDriver driver;
        public static ExtentReports extentreportobj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;

        [OneTimeSetUp]
       
        public void LoginFunction()
        {

            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\mrudu\Desktop\Reshma\Industry Connect\INTERNSHIP\ProjectMars_CompetitionTask\ProjectMars_CompetitionTaskRepo\ProjectMarsCompetitionTask\ExtentReports\");
            extentreportobj = new ExtentReports();
            extentreportobj.AttachReporter(htmlreporter);

            //Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginPageMethod(driver);

        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            extentreportobj.Flush();
            //driver.Quit();
        }
    }
}
