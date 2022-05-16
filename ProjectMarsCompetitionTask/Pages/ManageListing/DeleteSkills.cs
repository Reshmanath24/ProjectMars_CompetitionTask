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
    internal class DeleteSkills
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")] IWebElement deleteBtn;
        public void DeleteSkillMethod(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
            Thread.Sleep(2000);
            //manageListing.Click();
            Thread.Sleep(5000);
            
              //  IWebElement deleteBtn = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));

                deleteBtn.Click();
                Thread.Sleep(5000);
                //confirm to delete from popup
                IWebElement confirmDel = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
                confirmDel.Click();
               
        }
    }
}
