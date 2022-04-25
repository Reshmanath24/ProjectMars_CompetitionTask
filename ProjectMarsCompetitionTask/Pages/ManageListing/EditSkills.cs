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

namespace ProjectMarsCompetitionTask.Pages.ManageListing
{
    internal class EditSkills
    {
        public void editSkillMethod(IWebDriver driver)
        {
            //clicking on managelisting option
            Thread.Sleep(5000);
            IWebElement manageListingIcon = driver.FindElement(By.XPath("//*[@id='service-detail-section']/section[1]/div/a[3]"));
            manageListingIcon.Click();
            Thread.Sleep(5000);

            //Wait.WaittobeVisible(driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 10);

            //click on edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            editButton.Click();
            Thread.Sleep(5000);

            //identify the title text box and editing the title
            IWebElement titleEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleEdit.Clear();
            titleEdit.SendKeys("Testing title edit");
            Thread.Sleep(3000);

            //Identify the description text box and editing the description
            IWebElement descriptionEditing = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionEditing.Clear();
            descriptionEditing.Click();
            descriptionEditing.SendKeys("Testing description edit");


            //Identify the category dropdown and choose category to edit
            IWebElement categoryDropdownEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdownEdit.Click();
            IWebElement MusicOption = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select/option[6]"));
            MusicOption.Click();

            //Identify the sub category and choose option to edit
            IWebElement subCategoryDropdownEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryDropdownEdit.Click();
            IWebElement songWriterOptionEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]"));
            songWriterOptionEdit.Click();

            //identify the remove button and click on it.
            IWebElement removeTag = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/span[1]/a"));
            removeTag.Click();

            //Identify the tag textbox and edit the tag
            IWebElement tagTextboxEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tagTextboxEdit.Click();
            tagTextboxEdit.SendKeys("#Sound Engineer");
            tagTextboxEdit.SendKeys(Keys.Enter);

            //Identify the new tag textbox and edit the new tag name
            IWebElement newTagTextboxEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            newTagTextboxEdit.Click();
            newTagTextboxEdit.SendKeys("#Composing");
            newTagTextboxEdit.SendKeys(Keys.Enter);

            //Select the Service type option in edit
            IWebElement serviceTypeOptionEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            serviceTypeOptionEdit.Click();

            //Select the location type option
            IWebElement locationTypeOptionEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            locationTypeOptionEdit.Click();

            //editing the start date for available days 
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.SendKeys("12052022");

            //editing the end date for available days
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.SendKeys("18052022");

            //deselecting the days as monday
            IWebElement monday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            monday.Click();

            //clearing the start time for monday
            IWebElement startTimeMon = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
            startTimeMon.SendKeys(Keys.Delete);

            //clearing the end time for monday
            IWebElement endTimeMon = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            endTimeMon.SendKeys(Keys.Delete);

            //deselecting the days as tuesday
            IWebElement tuesday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            tuesday.Click();

            //clearing the start time for Tuesday
            IWebElement startTimeTue = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input"));
            
            startTimeTue.SendKeys(Keys.Delete);

            //adding the end time for tuesday
            IWebElement endTimeTue = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input"));
            
            endTimeTue.SendKeys(Keys.Delete);

            //selecting the days as wednesday
            IWebElement wednesday = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input"));
            wednesday.Click();

            //editing the start time for available days for wednesday
            IWebElement startTimeEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input"));
            startTimeEdit.Click();
            startTimeEdit.SendKeys("1100");

            //editing the end time for wednesday
            IWebElement endTimeEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input"));
            endTimeEdit.Click();
            endTimeEdit.SendKeys("0200");

            //editing skill trade option
            IWebElement skillTradeEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            skillTradeEdit.Click();

            //editing the Credit value under skill trade
            IWebElement creditValue = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input"));
            creditValue.Click();
            creditValue.SendKeys("2");

            //Selecting the active status
            IWebElement activeStatusEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            activeStatusEdit.Click();

            //click on save button
            IWebElement saveButtonEdit = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButtonEdit.Click();
            
        }
    }
}
