using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMarsCompetitionTask.Pages
{
    public class HomePage
    {
       
            public void GoToHomePage(IWebDriver driver)
            {
                Thread.Sleep(3000);
                //Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 10);

                IWebElement shareSkillOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
                shareSkillOption.Click();
                Thread.Sleep(3000);
            }
            
        
    }
}
