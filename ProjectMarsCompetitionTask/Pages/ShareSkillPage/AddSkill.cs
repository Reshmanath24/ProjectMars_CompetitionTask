using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ProjectMarsCompetitionTask.Excel_Data_Reader;
using ProjectMarsCompetitionTask.ScreenShot;
using SeleniumExtras.PageObjects;
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
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")] IWebElement titleTextBox;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")] IWebElement descriptionTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select")] IWebElement categoryDropdown;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option[7]")] IWebElement programmingOption;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")] IWebElement subCategoryDropdown;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")] IWebElement tagTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")] IWebElement newTagTextbox;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")] IWebElement serviceTypeOption;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")] IWebElement locationTypeOption;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")] IWebElement startDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")] IWebElement endDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")] IWebElement monday;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")] IWebElement startTimeMon;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")] IWebElement endTimeMon;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")] IWebElement skillTrade;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")] IWebElement skillExchange;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")] IWebElement workSample;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")] IWebElement activeStatus;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")] IWebElement saveButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[2]")] IWebElement checkCategory;




        public void addSkillsMethod(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
            //identify the title text box and add the title
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);
            Thread.Sleep(3000);

            //Identify the description text box and add the description
            descriptionTextbox.Click();
            string description = ExcelReader.ReadData(1, "Description");

            descriptionTextbox.SendKeys(description);

            //Identify the category dropdown and choose category
            categoryDropdown.Click();
            string categoryRead = ExcelReader.ReadData(1, "Category");

            programmingOption.Click();

            //Identify the sub category and choose option
            
            subCategoryDropdown.Click();
            
            //Identify the tag textbox and enter a tag
            tagTextbox.Click();
            string tagName = ExcelReader.ReadData(1, "Tags");

            tagTextbox.SendKeys(tagName);
            tagTextbox.SendKeys(Keys.Enter);

            //Identify the new tag textbox and enter the new tag name
            newTagTextbox.Click();
            string newTagName = ExcelReader.ReadData(1, "New tag");

            newTagTextbox.SendKeys(newTagName);

            //Select the Service type option
            serviceTypeOption.Click();

            //Select the location type option
            locationTypeOption.Click();

            //adding the start date for available days 
            string startDateCol = ExcelReader.ReadData(1, "Start Date");

            startDate.SendKeys(startDateCol);

            //adding the end date for available days
            string endDateCol = ExcelReader.ReadData(1, "End Date");

            endDate.SendKeys(endDateCol);

            //selecting the days as monday
            monday.Click();

            //adding the start time for monday
            startTimeMon.Click();
            string startTimeCol = ExcelReader.ReadData(1, "Start time");

            startTimeMon.SendKeys(startTimeCol);

            //adding the end time for monday
            endTimeMon.Click();
            string endTimeCol = ExcelReader.ReadData(1, "End time");

            endTimeMon.SendKeys(endTimeCol);

            //selecting skill trade option
            skillTrade.Click();

            //selecting skill exchange
            skillExchange.Click();
            string skillExchangeCol = ExcelReader.ReadData(1, "Skill Exchange");

            skillExchange.SendKeys(skillExchangeCol);
            skillExchange.SendKeys(Keys.Enter);

            //uploading a work sample

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
            activeStatus.Click();
            Thread.Sleep(3000);
            

            //click on save button
            saveButton.Click();
            Thread.Sleep(3000);
            

            Assert.That(checkCategory.Text == "Programming & Tech", "Skill not created");

        }
    }
}
