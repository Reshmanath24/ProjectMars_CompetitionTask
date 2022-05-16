using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMarsCompetitionTask.ScreenShot;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMarsCompetitionTask.Pages.ManageListing
{
    public class ViewSkill
    {
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")] IWebElement manageListingClick;
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i")] IWebElement viewIcon;
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]")] IWebElement viewActualValueCheck;
        

        public void viewSkillsMethod(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            Thread.Sleep(3000);
            //click on manage listing option 
          //  manageListingClick.Click();

            Thread.Sleep(3000);
            //click on the eye icon to view the saved skills
            viewIcon.Click();
            Thread.Sleep(5000);

            //checking the same value value is viewing
            Thread.Sleep(2000);
            Assert.That(viewActualValueCheck.Text == "Automation Testing Description", "Not viewing the right element");
            

        }
    }
}
