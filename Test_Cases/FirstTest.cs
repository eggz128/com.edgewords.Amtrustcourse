using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using com.edgewords.Amtrustcourse.Base_Classes;

namespace com.edgewords.Amtrustcourse.Test_Cases
{
    
    public class FirstTest : Base_Classes.TestBaseClass
    {
        
        string Base_URL = "https://www.edgewordstraining.co.uk/webdriver2/sdocs/auth.php";
        [Test]
        public void MyTest()
        {
            //// TODO: Add your test code here
            //var answer = 41;
            //Assert.That(answer, Is.EqualTo(42), "Number not 42");

            //var options = new ChromeOptions();
            //options.AddArgument("start-maximized");


            //driver = new ChromeDriver(options); //Opens chrome
            driver.Url = Base_URL; //Navigate to URL

            

            //Does some user actions
            IWebElement UsernameField = driver.FindElement(By.Id("username"));
            UsernameField.SendKeys("Edgewords");
            //UsernameField.Clear();
            UsernameField.SendKeys(Keys.Control + "a");
            UsernameField.SendKeys(Keys.Delete);
            UsernameField.SendKeys("Steve");

            var InputText = UsernameField.GetAttribute("value");
            Console.WriteLine("Username is " + InputText);


            var TheText = driver.FindElement(By.TagName("h1")).Text;

            Console.WriteLine("The text was: " + TheText);
            //driver.FindElement(By.Id("password")).SendKeys("edgewords123");
            //driver.FindElement(By.LinkText("Submit")).Click();

           

            Console.WriteLine("Finished!");
            Console.WriteLine("Yes really!");

            //Assert.Pass("This passed");
            //driver.Close();
            driver.Quit();
        }


    }
}
