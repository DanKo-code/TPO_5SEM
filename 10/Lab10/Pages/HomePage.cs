using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Pages
{
    public class HomePage : AbstractPage
    {
        private string url = "https://www.wildberries.by/";

        public HomePage(IWebDriver webDriver) : base(webDriver) { }

        ///////////////////////////////////////////////////////

        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void WriteAndEnterInput(By locator, string data)
        {
            IWebElement search = driver.FindElement(locator);

            search.SendKeys(data);

            search.SendKeys(Keys.Enter);
        }

        public void SearchProduct(string data)
        {
            WriteAndEnterInput(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[2]/div/div/div[1]/div/input"), data);
        }

        public string GetSearchResult()
        {
            return driver.Title;
        }

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
