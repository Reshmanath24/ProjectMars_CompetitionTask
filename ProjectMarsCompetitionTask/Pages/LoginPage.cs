using NUnit.Framework;
using OpenQA.Selenium;
using ProjectMarsCompetitionTask.Excel_Data_Reader;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectMarsCompetitionTask.Pages
{
    public class LoginPage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        public IWebElement signInButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement emailTextBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton;
        public void LoginPageMethod(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);

            //Launch the portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            try
            {
                //Login Page
                //============
                //Click on sign in button
                //IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signInButton.Click();
                ////Identify the email address text box and enter the valid email address
                //IWebElement emailTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                string userName= ExcelReader.ReadData(1,"UserName");
                emailTextBox.SendKeys(userName);
                ////Identify the password text box and enter the valid password
                //IWebElement passwordTextBox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                string password = ExcelReader.ReadData(1, "Password");
                passwordTextBox.SendKeys(password);
                ////Click on sign in button
                //IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("LoginPage page did not launch", ex.Message);
                throw;
            }

            Thread.Sleep(5000);

            //Check whether the logged in user is same
            IWebElement actualUser = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Thread.Sleep(5000);
            if (actualUser.Text == "Hi Reshma")
            {
                Console.WriteLine("User logged in successfully");
            }
            else
            {
                Console.WriteLine("Invalid user, test failed");
            }
        }
    }
}
