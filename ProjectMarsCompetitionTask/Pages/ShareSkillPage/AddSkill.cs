using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ProjectMarsCompetitionTask.Excel_Data_Reader;
using ProjectMarsCompetitionTask.ScreenShot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ProjectMarsCompetitionTask.Pages.ShareSkillPage
{
    internal class AddSkill
    {
        public void addSkillsMethod(IWebDriver driver)
        {
            //identify the title text box and add the title
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);
            Thread.Sleep(3000);

            //Identify the description text box and add the description
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionTextbox.Click();
            string description = ExcelReader.ReadData(1, "Description");

            descriptionTextbox.SendKeys(description);

            //Identify the category dropdown and choose category
            IWebElement categoryDropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdown.Click();
            string categoryRead = ExcelReader.ReadData(1, "Category");

            IWebElement programmingOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option["+categoryRead+"]"));
            programmingOption.Click();

            //Identify the sub category and choose option
            IWebElement subCategoryDropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryDropdown.Click();
            IWebElement qaOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]"));
            qaOption.Click();
            
            //Identify the tag textbox and enter a tag
            IWebElement tagTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagTextbox.Click();
            string tagName = ExcelReader.ReadData(1, "Tags");

            tagTextbox.SendKeys(tagName);
            tagTextbox.SendKeys(Keys.Enter);

            //Identify the new tag textbox and enter the new tag name
            IWebElement newTagTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            newTagTextbox.Click();
            string newTagName = ExcelReader.ReadData(1, "New tag");

            newTagTextbox.SendKeys(newTagName);

            //Select the Service type option
            IWebElement serviceTypeOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            serviceTypeOption.Click();

            //Select the location type option
            IWebElement locationTypeOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationTypeOption.Click();

            //adding the start date for available days 
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            string startDateCol = ExcelReader.ReadData(1, "Start Date");

            startDate.SendKeys(startDateCol);

            //adding the end date for available days
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            string endDateCol = ExcelReader.ReadData(1, "End Date");

            endDate.SendKeys(endDateCol);

            //selecting the days as monday
            IWebElement monday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            monday.Click();

            //adding the start time for monday
            IWebElement startTimeMon = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            startTimeMon.Click();
            string startTimeCol = ExcelReader.ReadData(1, "Start time");

            startTimeMon.SendKeys(startTimeCol);

            //adding the end time for monday
            IWebElement endTimeMon = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            endTimeMon.Click();
            string endTimeCol = ExcelReader.ReadData(1, "End time");

            endTimeMon.SendKeys(endTimeCol);

            ////selecting the days as tuesday
            //IWebElement tuesday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            //tuesday.Click();

            ////adding the start time for Tuesday
            //IWebElement startTimeTue = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
            //startTimeTue.Click();
            //string startTimeTueCol = ExcelReader.ReadData(1, "End time");

            //startTimeTue.SendKeys(startTimeTueCol);

            ////adding the end time for tuesday
            //IWebElement endTimeTue = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
            //endTimeTue.Click();
            //endTimeTue.SendKeys("0600");

            //selecting skill trade option
            IWebElement skillTrade = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTrade.Click();

            //selecting skill exchange
            IWebElement skillExchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillExchange.Click();
            string skillExchangeCol = ExcelReader.ReadData(1, "Skill Exchange");

            skillExchange.SendKeys(skillExchangeCol);
            skillExchange.SendKeys(Keys.Enter);

            //uploading a work sample

            IWebElement workSample = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            workSample.Click();

            //approach 1 to upload a file:Sendkeys
            //workSample.SendKeys(@"C:\Users\mrudu\Desktop\Reshma\Industry Connect\TRAINING\CREATING AN SSH KEY_.pdf");

            //approach 2:AutoIt Handles windows that do not belong to browser
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            Thread.Sleep(2000);
            autoIt.Send(@"C:\Users\mrudu\Desktop\Reshma\Testing");
            Thread.Sleep(2000);
            autoIt.Send("{ENTER}");

            //Selecting the active status
            IWebElement activeStatus = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            activeStatus.Click();
            Thread.Sleep(3000);
            

            //click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
            Thread.Sleep(3000);
            //var element = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element);
            //actions.Perform();

            //check if shareskill record was created 
            //IWebElement manageListingIcon = driver.FindElement(By.XPath("//*[@id='service-detail-section']/section[1]/div/a[3]"));
            //manageListingIcon.Click();
            //Thread.Sleep(2000);

            //IWebElement checkCategory = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
            //Assert.That(checkCategory.Text == "Programming & Tech", "Skill not created");

        }
    }
}
