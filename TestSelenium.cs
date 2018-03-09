using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Test
{
    class TestSelenium
    {
        IWebDriver driver;
        


        [SetUp]
        public void StartBrowser()
        {
            driver = new FirefoxDriver();
        }

        public void GoToURL(string url)
        {
            this.driver.Url = url;
        }

        public void Sleep(int seconds)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }

        public IWebElement WaitForElement(By by, int timeoutSeconds)
        {
            if (timeoutSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        [Test]
        public void TestDanica()
        {
            GoToURL("https://www.qtptutorial.net/automation-practice/");
            Sleep(3);

            //IWebElement buttonId = WaitForElement(By.XPath("//input[@id='idExample']"), 1);
            //buttonId.Click();
            //Sleep(2);

            //IWebElement buttonIdText1 = driver.FindElement(By.ClassName("main_title"));

            //GoToURL("https://www.qtptutorial.net/automation-practice/");
            //Sleep(3);

            //IWebElement buttonClass = WaitForElement(By.XPath("//input[@class='buttonClassExample']"), 1);
            //buttonClass.Click();
            //Sleep(2);

            //IWebElement buttonIdText2 = driver.FindElement(By.ClassName("main_title"));

            //GoToURL("https://www.qtptutorial.net/automation-practice/");
            //Sleep(3);


            //IWebElement buttonName = WaitForElement(By.Name("NameExample"), 1);
            //buttonName.Click();
            //Sleep(2);

            //IWebElement buttonIdText3 = driver.FindElement(By.ClassName("main_title"));


            //GoToURL("https://www.qtptutorial.net/automation-practice/");
            //Sleep(3);

            //IWebElement buttoneMail = driver.FindElement(By.ClassName("et_pb_newsletter_button"));

            //string name = "Danica";
            //string email = "dgojko@gmail.com";

            //driver.FindElement(By.Id("et_pb_signup_firstname")).SendKeys(name);

            //driver.FindElement(By.Id("et_pb_signup_email")).SendKeys(email);

            IWebElement tableUniq = driver.FindElement(By.Id("htmlTableId"));

            IWebElement iznos = tableUniq.FindElement(By.XPath("//td[contains(.,'$120,000+')]"));

            IList<IWebElement> tableUniqRow = tableUniq.FindElements(By.XPath("//td[@class='xh-highlight']"));
            foreach (var item in tableUniqRow)
            {
                System.IO.File.AppendAllText("g:\\QA testing - Rajak\\Results\\34.txt", item.Text.ToString() + Environment.NewLine);
            }




        }






        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
