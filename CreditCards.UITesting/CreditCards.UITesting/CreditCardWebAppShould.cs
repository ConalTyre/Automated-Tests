using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace CreditCards.UITesting
{
    public class CreditCardWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http:\\www.FoodsConnected.com");
            }

        }
    }
}
