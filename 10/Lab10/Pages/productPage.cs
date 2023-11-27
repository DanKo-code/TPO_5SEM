using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Pages
{
    public class ProductPage : AbstractPage
    {
        private string url = "https://www.wildberries.by/product?card=172028009&tail-location=MCV&option=285473185";

        public ProductPage(IWebDriver webDriver) : base(webDriver) { }

        ///////////////////////////////////////////////////////

        public bool checkExistanceElement(By locator)
        {
            return driver.FindElement(locator) != null;
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
