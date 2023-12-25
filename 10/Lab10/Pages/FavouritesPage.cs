using MyWebSiteCaseTests.Pages;
using NLog;
using OpenQA.Selenium;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Pages
{
    public class FavouritesPage : AbstractPage
    {
        private string url = "https://www.wildberries.by/profile/favourites";

        public FavouritesPage(IWebDriver webDriver) : base(webDriver) { }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool isFavouritProductExists(string productName)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[6]/div/div/div/div/div/div[2]/button[2]")).Click();

            Thread.Sleep(2000);
            string pn = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div[3]/div[2]/div/div[1]/a/div[2]/div[5]/span[2]")).Text;


            string resPn = deleteExtraProductNameSymbols(pn);

            return resPn == productName;
        }

        public string deleteExtraProductNameSymbols(string originalString)
        {
            string stringWithoutDots = originalString.Replace("· ", "");
            return stringWithoutDots;
        }
    }
}
