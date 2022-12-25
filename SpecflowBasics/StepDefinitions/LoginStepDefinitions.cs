using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowBasics.Collections;
using System;
using TechTalk.SpecFlow;

namespace SpecflowBasics.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions:BaseCollection
    {
        [Given(@"Going to the login page")]
        public void GivenGoingToTheLoginPage()
        {

            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(LoginPage.loginpageUrl);
        }

        [Given(@"filling the username and password fields")]
        public void GivenFillingTheUsernameAndPasswordFields()
        {
            webDriver.FindElement(By.XPath("//input[@name='session_key']")).SendKeys(LoginPage.username);
            webDriver.FindElement(By.XPath("//input[@name='session_password']")).SendKeys(LoginPage.password);
        }

        [When(@"click the login button")]
        public void WhenClickTheLoginButton()
        {
            webDriver.FindElement(By.XPath("//button[@class='sign-in-form__submit-button']")).Click();
        }

        [Then(@"I see the home page")]
        public void ThenISeeTheHomePage()
        {
            webDriver.Quit();
        }
    }
}
