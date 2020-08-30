using Bank_Application.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Bank_Application.StepDefinition
{
    [Binding]
    public class LogInSteps
    {
        LogInPage LoginObject = null;
       

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://www.demo.guru99.com/V4/");
            webDriver.Manage().Window.Maximize();
            LoginObject = new LogInPage(webDriver);
        }
        
        [Given(@"I enter the details")]
        public void GivenIEnterTheDetails(Table table)
        {
            //CreateDynamicInstance() method will read data from table in Feature file
            dynamic data = table.CreateDynamicInstance();

            //the stored User/Pse in data variable pass the value Username variable from Feature file
            LoginObject.EnterDetails((string)data.UserName, (string)data.Password);
        }
        
        [When(@"I Click on LogIn Button")]
        public void WhenIClickOnLogInButton()
        {
            LoginObject.ClickOnLogin();
        }
        
        [Then(@"I should view Logged In Screen")]
        public void ThenIShouldViewLoggedInScreen()
        {
            
        }
    }
}
