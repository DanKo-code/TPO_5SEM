using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Pages
{
    internal class CartPage : AbstractPage
    {
        private string url = "https://www.wildberries.by/basket";

        public CartPage(IWebDriver webDriver) : base(webDriver) { }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool isCartProductExists(string productName)
        {
            Thread.Sleep(2000);
            string pn = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div[1]/div[3]/section[1]/section/div[2]/div/div[2]/div/div/div[2]/a/span")).Text;
            return pn == productName;
        }
    }
}
