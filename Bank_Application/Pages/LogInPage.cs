using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Application.Pages
{
    public class LogInPage
    {
        public IWebDriver WebDriver { get; }

        public LogInPage(IWebDriver webDriver)
        {
           WebDriver = webDriver;
        }

        //UI Elements
        //UserName TextBox
        public IWebElement UserNameTxtBox => WebDriver.FindElement(By.Name("uid"));
        //Password TextBox WebElement
        public IWebElement PasswordTxtBox => WebDriver.FindElement(By.Name("password"));
        //LogIn Button 
        public IWebElement LogInBtn => WebDriver.FindElement(By.Name("btnLogin"));


        //Method
        //Entering details 
        public void EnterDetails(string Username, String password)
        {
            UserNameTxtBox.SendKeys(Username);
            PasswordTxtBox.SendKeys(password);
        }

        //Click on LogIn
        public void ClickOnLogin() => LogInBtn.Click();

    }
}
