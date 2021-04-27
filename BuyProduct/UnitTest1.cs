using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace BuyProduct
{
    public class Tests
    {
        String test_url = "http://automationpractice.com/index.php";
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

            IWebElement searchText = driver.FindElement(By.CssSelector("#search_query_top"));

            searchText.SendKeys("Blouse");

            IWebElement searchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div[2]/form/button"));


            searchButton.Click();

            IWebElement listDetail = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/div[1]/div[1]/ul/li[3]/a/i"));

            listDetail.Click();


            IWebElement mouseEvent = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div/div[3]/div/div[2]/a[1]"));

            mouseEvent.Click();


            System.Threading.Thread.Sleep(3000);

            IWebElement searchDress = driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a"));

            searchDress.Click();


            IWebElement proceedCheckout = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]"));

            proceedCheckout.Click();


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