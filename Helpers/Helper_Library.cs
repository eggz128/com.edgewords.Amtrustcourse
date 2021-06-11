using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using LumenWorks.Framework.IO.Csv;

namespace com.edgewords.Amtrustcourse.Helpers
{
    public static class Helper_Library
    {
        public static IWebElement WaitForElement(IWebDriver driver, By locator, int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            IWebElement theelement = wait.Until(driver => driver.FindElement(locator));
            return theelement;
        }

        public static void AcceptAlert(IWebDriver driver)
        {
            var thealert = driver.SwitchTo().Alert();
            
            Console.WriteLine("The alert text was: " + thealert.Text);
            thealert.Accept();
        }

        public static void TakeScreenshot(IWebDriver driver, string filename)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot thescreenshot = ssdriver.GetScreenshot();
            thescreenshot.SaveAsFile(@"c:\users\edgewords\pictures\amtrust\" + filename +".png", ScreenshotImageFormat.Png);

        }

        public static void TakeScreenshotOfElement(IWebElement theelement, string filename)
        {
            ITakesScreenshot ssdriver = theelement as ITakesScreenshot;
            Screenshot thescreenshot = ssdriver.GetScreenshot();
            thescreenshot.SaveAsFile(@"c:\users\edgewords\pictures\amtrust\" + filename + ".png", ScreenshotImageFormat.Png);

        }

        public static IEnumerable<string[]> GetTestData()
        {
            var csvFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase) + "\\data.csv";
            csvFile = new Uri(csvFile).LocalPath;

            using (var csv = new CsvReader(new StreamReader(csvFile), true))
            {
                while (csv.ReadNextRecord())
                {
                    string data1 = csv[0];
                    string data2 = csv[1];
                    yield return new[] { data1, data2 };
                }
            }
        }

    }
}
