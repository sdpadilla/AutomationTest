using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace VerifyMail
{
    public class Tests
    {
        String test_url = "https://reqres.in/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            // Local Selenium WebDriver
            var op = new FirefoxOptions
            {
                AcceptInsecureCertificates = true
            };
            driver = new FirefoxDriver(op);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test_search()
        {
            driver.Url = test_url;



            System.Threading.Thread.Sleep(500);

            IWebElement searchPage2 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/section[1]/div[2]/div[1]/p/strong/a/span"));




            searchPage2.Click();

            IWebElement searchText = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div/div/div[1]/input"));

            searchText.SendKeys("michael.lawson@reqres.in");


            System.Threading.Thread.Sleep(6000);

            Console.WriteLine("Test Passed");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}