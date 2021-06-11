using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.edgewords.Amtrustcourse.POM_Pages
{
    public class HomePage
    {
        IWebDriver driver; //Field to hold passed driver instance from test

        //Constructor to accept driver from test and put it in field above
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Define the needed WebElements

        IWebElement LoginLink => driver.FindElement(By.PartialLinkText("Login"));

        //Service Methods
        public void GoLogin()
        {
            LoginLink.Click();
        }


    }
}
