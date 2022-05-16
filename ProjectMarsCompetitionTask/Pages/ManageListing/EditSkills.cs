using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMarsCompetitionTask.Utilities;
using System.Threading;
using ProjectMarsCompetitionTask.ScreenShot;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using NUnit.Framework;

namespace ProjectMarsCompetitionTask.Pages.ManageListing
{
    public class EditSkills
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/section[1]/div/a[3]")] IWebElement manageListingClick;

        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")] IWebElement editButton;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")] IWebElement titleEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")] IWebElement descriptionEditing;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]")] IWebElement MusicOption;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]")] IWebElement songWriterOptionEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a")] IWebElement removeTag;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")] IWebElement tagTextboxEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")] IWebElement newTagTextboxEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")] IWebElement serviceTypeOptionEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")] IWebElement locationTypeOptionEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input")] IWebElement startDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input")] IWebElement endDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")] IWebElement monday;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")] IWebElement startTimeMon;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")] IWebElement endTimeMon;
        
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")] IWebElement wednesday;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")] IWebElement startTimeEdit;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")] IWebElement endTimeEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")] IWebElement skillTradeEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")] IWebElement creditValue;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")] IWebElement activeStatusEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]")] IWebElement saveButtonEdit;
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")] IWebElement editCheckTitle;


        public void editSkillMethod(IWebDriver driver)
        {

            PageFactory.InitElements(driver,this);
            //clicking on managelisting option
            Thread.Sleep(5000);
           manageListingClick.Click();
          
            //click on edit button
            Thread.Sleep(5000);
            editButton.Click();
            Thread.Sleep(3000);

            //identify the title text box and editing the title
            titleEdit.Clear();
            titleEdit.SendKeys("Testing title edit");
            Thread.Sleep(3000);

            //Identify the description text box and editing the description
            
            descriptionEditing.Clear();
            descriptionEditing.Click();
            descriptionEditing.SendKeys("Testing description edit");

            //Identify the category dropdown and choose category to edit
            MusicOption.Click();

            //Identify the sub category and choose option to edit
           
            songWriterOptionEdit.Click();

            //identify the remove button and click on it.
            removeTag.Click();

            //Identify the tag textbox and edit the tag
            
            tagTextboxEdit.Click();
            tagTextboxEdit.SendKeys("#Sound Engineer");
            tagTextboxEdit.SendKeys(Keys.Enter);

            //Identify the new tag textbox and edit the new tag name
            
            newTagTextboxEdit.Click();
            newTagTextboxEdit.SendKeys("#Composing");
            newTagTextboxEdit.SendKeys(Keys.Enter);

            //Select the Service type option in edit
            serviceTypeOptionEdit.Click();

            //Select the location type option
            locationTypeOptionEdit.Click();

            //editing the start date for available days 
            startDate.SendKeys("25052022");

            //editing the end date for available days
            
            endDate.SendKeys("30052022");

            //deselecting the days as monday
            
            monday.Click();

            //clearing the start time for monday
            startTimeMon.SendKeys(Keys.Delete);

            //clearing the end time for monday
            endTimeMon.SendKeys(Keys.Delete);

            //selecting the days as wednesday
            wednesday.Click();

            //editing the start time for available days for wednesday
            startTimeEdit.Click();
            startTimeEdit.SendKeys("1100");

            //editing the end time for wednesday
            endTimeEdit.Click();
            endTimeEdit.SendKeys("0200");

            //editing skill trade option
            skillTradeEdit.Click();

            //editing the Credit value under skill trade
            creditValue.Click();
            creditValue.SendKeys("2");

            //Selecting the active status
            activeStatusEdit.Click();

            //click on save button
            saveButtonEdit.Click();
            Thread.Sleep(5000);
            Assert.That(editCheckTitle.Text == "Testing title edit", "Skill not edited");

        }
    }
}
