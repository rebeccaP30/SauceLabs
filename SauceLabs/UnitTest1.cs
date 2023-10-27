using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace SauceLabs
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            
            
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--ignore-certificate-errors");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            driver.Url = "https://www.saucedemo.com/?ref=hackernoon.com";
            
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            Thread.Sleep(4000);
            driver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("shopping_cart_container")).Click();
            driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("first-name")).SendKeys("Rebecca");
            driver.FindElement(By.Id("last-name")).SendKeys("Phakathi");
            driver.FindElement(By.Id("postal-code")).SendKeys("0157");
            Thread.Sleep(4000);
            driver.FindElement(By.Id("continue")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("finish")).Click();
            
        }
    }
}