using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMarsCompetitionTask.Excel_Data_Reader;
using ProjectMarsCompetitionTask.Pages;
using ProjectMarsCompetitionTask.Pages.ManageListing;
using ProjectMarsCompetitionTask.Pages.ShareSkillPage;
using ProjectMarsCompetitionTask.ScreenShot;
using ProjectMarsCompetitionTask.Utilities;
using System;
using System.Diagnostics;
using System.IO;

namespace ProjectMarsCompetitionTask
{
    [TestFixture]
    internal class ShareSkill_Test:CommonDriver
    {
        [Test,Order(1)]
        public void ExcelReaderMethod()
        {
            try
            {           
                ExcelReader.ClearData();                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        [Test, Order(2)]
        public void AddSkillPage()
        {
            ExcelReader.ReadDataTable(stream, "ShareSkill");
            try
            {
                test = extentreportobj.CreateTest("AddSkillPage", "Testing of add skill page");
                HomePage HomePageObj = new HomePage();
                HomePageObj.GoToHomePage(driver);
                test.Log(Status.Info, "ShareSkill page opened");

                AddSkill addSkillPageObj = new AddSkill();
                addSkillPageObj.addSkillsMethod(driver);
                TakeScreenShot.ScreenShotMethod(driver);
                test.Log(Status.Info, "Skills saved successfully");
                test.Log(Status.Pass, "AddSkillPage executed successfully, test passed");
            }
            catch
            {
                test.Log(Status.Fail, "skills not added");
            }
        }
        [Test, Order(3)]

        public void ViewSkill()

        {

            test = extentreportobj.CreateTest("ViewSkill", "Testing of view page");
            ViewSkill viewSkillObj = new ViewSkill();
            viewSkillObj.viewSkillsMethod(driver);
            TakeScreenShot.ScreenShotMethod(driver);
            test.Log(Status.Info, "View page opened successfully");
            test.Log(Status.Pass, "Test passed");
        }
        [Test, Order(4)]

        public void EditSkills()
        {
            test = extentreportobj.CreateTest("EditSkills", "Testing of edit page");
            EditSkills editSkillsObj = new EditSkills();
            editSkillsObj.editSkillMethod(driver);
            TakeScreenShot.ScreenShotMethod(driver);

            test.Log(Status.Info, "Skills editted successfully");
            test.Log(Status.Pass, "Test passed");
        }
        [Test, Order(5)]
        public void DeleteSkills()
        {
            test = extentreportobj.CreateTest("DeleteSkills", "Testing of delete page");
            DeleteSkills deleteSkillsObj = new DeleteSkills();
            deleteSkillsObj.DeleteSkillMethod(driver);
            TakeScreenShot.ScreenShotMethod(driver);
            test.Log(Status.Info, "Skills deleted successfully");
            test.Log(Status.Pass, "test passed");
        }


    }
    
}
