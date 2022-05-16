using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")] IWebElement shareSkillOption;



            public void GoToHomePage(IWebDriver driver)
            {
            PageFactory.InitElements(driver,this);
                Thread.Sleep(3000);
                //Wait.WaittobeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 10);

                //IWebElement shareSkillOption = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
                shareSkillOption.Click();
                Thread.Sleep(3000);
            }
            
        
    }
}
