using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Edge;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.IE;

namespace com.edgewords.Amtrustcourse.Base_Classes
{
    public class TestBaseClass
    {
        protected IWebDriver driver; //Probably has to be public

        [SetUp]
        public void SetUp()
        {

            string browser = Environment.GetEnvironmentVariable("browser", EnvironmentVariableTarget.Process);


            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.Host = "::1";
                    driver = new FirefoxDriver(service);
                    break;
                default: 
                    driver = new ChromeDriver();
                    break;

            }
            
            
            
            
            //var options = new ChromeOptions();
            //options.AddArgument("start-maximized");


            //driver = new ChromeDriver(options); //Opens chrome
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            //service.Host = "::1";
            //driver = new FirefoxDriver(service);

            //driver = new FirefoxDriver();

            //var options = new EdgeOptions();
            //options.UseChromium = true;

            //driver = new EdgeDriver(options);

            //driver = new InternetExplorerDriver();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }


    }
}
