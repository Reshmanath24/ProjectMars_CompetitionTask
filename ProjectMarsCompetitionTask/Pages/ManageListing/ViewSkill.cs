using OpenQA.Selenium;
using ProjectMarsCompetitionTask.ScreenShot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMarsCompetitionTask.Pages.ManageListing
{
    internal class ViewSkill
    {
        public void viewSkillsMethod(IWebDriver driver)
        {
            //click on manage listing option 
            
            Thread.Sleep(5000);
            //IWebElement manageListingIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
            //manageListingIcon.Click();
            //Thread.Sleep(5000);

            //click on the eye icon to view the saved skills
            IWebElement viewIcon = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));
            viewIcon.Click();
            Thread.Sleep(5000);

            //checking the same value value is viewing
            IWebElement viewActualValueCheck = driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));
            Thread.Sleep(2000);
            if(viewActualValueCheck.Text == "Automation Testing using Selenium CSharp")
            {
                Console.WriteLine("Actual value is viewing");
            }
            else
            {
                Console.WriteLine("Wrong data displayed,Test failed");
            }
           
        }
    }
}
