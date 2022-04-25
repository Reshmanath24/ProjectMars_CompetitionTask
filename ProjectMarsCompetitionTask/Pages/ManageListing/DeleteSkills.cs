using NUnit.Framework;
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
    internal class DeleteSkills
    {
        public void DeleteSkillMethod(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //click on delete button
            IWebElement delCheck = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
            Thread.Sleep(5000);
            if(delCheck.Text == "Testing description edit")
            {
                IWebElement deleteBtn = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]"));

                deleteBtn.Click();
                Thread.Sleep(5000);
                //confirm to delete from popup
                IWebElement confirmDel = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
                confirmDel.Click();
               
            }
            else
            {
                Assert.Fail("Test failed");
            }
        }
    }
}
