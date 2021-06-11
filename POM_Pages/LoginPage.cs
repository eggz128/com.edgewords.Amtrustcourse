using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.edgewords.Amtrustcourse.POM_Pages
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            Assert.That(driver.Title, Is.EqualTo("Automated Tools Test Site"), "We are on the wrong page");
        }

        //Locators
        IWebElement UsernameField => driver.FindElement(By.Id("username"));
        public IWebElement PasswordField => driver.FindElement(By.Id("password"));
        IWebElement SubmitButton => driver.FindElement(By.LinkText("Submit"));
        IWebElement ClearButton => driver.FindElement(By.LinkText("Clear"));

        IWebElement SlowElement => new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => drv.FindElement(By.Id("1")));


        //Service methods

        public LoginPage SetUsername(string UsernameText)
        {
            UsernameField.Clear();
            UsernameField.SendKeys(UsernameText);
            return this;
        }

        public void SetPassword(string PasswordText)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(PasswordText);
        }

        public void SubmitForm()
        {
            SubmitButton.Click();
        }


        //Helper service
        public void Login(string username, string password)
        {
            ClearButton.Click();
            SetUsername(username);
            SetPassword(password);
            SubmitForm();
        }

    }
}
