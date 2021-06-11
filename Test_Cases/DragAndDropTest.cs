// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using com.edgewords.Amtrustcourse.Base_Classes;

namespace com.edgewords.Amtrustcourse.Test_Cases
{
    [TestFixture]
    public class DragAndDropTest : Base_Classes.TestBaseClass
    {
        



        [Test]
        public void dragAndDrop()
        {
            // Test name: DragAndDrop
            // Step # | name | target | value
            // 1 | open | https://www.edgewordstraining.co.uk/training-site/ | 
            driver.Navigate().GoToUrl("https://www.edgewordstraining.co.uk/training-site/");
            // 2 | setWindowSize | 1087x1031 | 
            driver.Manage().Window.Size = new System.Drawing.Size(1087, 1031);
            // 3 | click | css=.last span | 
            driver.FindElement(By.CssSelector(".last span")).Click();
            // 4 | mouseDownAt | css=.ui-slider-handle | 9.546875,12.1875
            {
                var element = driver.FindElement(By.CssSelector(".ui-slider-handle"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().MoveByOffset(100, 0).Release().Build().Perform();
            }
            
        }
    }
}