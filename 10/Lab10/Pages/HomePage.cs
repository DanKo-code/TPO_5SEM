using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.CacheStorage;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool isCurrentPageHome()
        {
            Thread.Sleep(2000);
            string currentUrl = driver.Url;
            return currentUrl == "https://www.wildberries.by/";
        }

        public void clickGoPurchaseButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[2]/div/div/a")).Click();
        }

        public bool isCarouselSequenceFollowed(string imgName)
        {
            Thread.Sleep(2000);
            string currentImg = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div/div[1]/div/div[1]/a/picture/img")).Text;
            return imgName == currentImg;
        }

        public void switchCarouselLeft()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div/div[1]/button[1]")).Click();
        }

        public void switchCarouselRight()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div/div[1]/button[2]")).Click();
        }

        public string getCurrentCarouselName()
        {
            Thread.Sleep(2000);
            string imgName = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div/div[1]/div/div[1]/a/picture/img")).Text;
            return imgName;
        }

        public void canselCookies()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[6]/div/div/div/div/div/div[2]/button[2]")).Click();
        }

        public bool isWeOnTheTop()
        {
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return (bool)js.ExecuteScript("return window.scrollY === 0;");
        }

        public void clickGoTopButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[4]")).Click();
        }

        public void scrollToBottom()
        {
            Thread.Sleep(2000);
            // Прокрутка в самый низ
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public bool isCellSearchCorrect(string productName)
        {
            Thread.Sleep(2000);
            string pageTitle = GetPageTitle();

            return productName == pageTitle;
        }

        public string selectSearchCell()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[2]/div/div/div[1]/button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[8]/div[1]/div[1]/ul/li[5]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[8]/div[1]/div[2]/ul/li[1]")).Click();
            Thread.Sleep(1000);
            IWebElement button = driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[8]/div[1]/div[3]/ul/li[1]"));


            string buttonName = driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/div[8]/div[1]/div[3]/ul/li[1]/span")).Text;
            button.Click();

            return buttonName;
        }

        public bool isCurrencyChanged()
        {
            Thread.Sleep(2000);
            string priceName = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[2]/div[1]/span/span[1]/span[2]")).Text;

            return priceName[priceName.Length-1] == '₽';
        }

        public void changeCurrency()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[1]/div[2]/div[2]/div/button")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[1]/div[2]/div[2]/div/div/ul/li[1]")).Click();
        }

        public bool equalFastModalNameWithProductName(string productName)
        {
            Thread.Sleep(2000);

            string FastModalName = driver.FindElement(By.XPath("/html/body/div[14]/div[1]/div[1]/div[2]/div/div[1]/div[1]/div[1]/div/div/h1/span")).Text;

            return productName == FastModalName;
        }

        public string ClickProductFustShowingButton()
        {
            Thread.Sleep(2000);
            string originalString = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[2]/div[3]/span[2]")).Text;

            Thread.Sleep(2000);
            IWebElement productCard = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]"));

            Thread.Sleep(2000);
            // Создание экземпляра Actions
            Actions actions = new Actions(driver);
            actions.MoveToElement(productCard).Perform();

            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[1]/div[2]/button")).Click();

            Thread.Sleep(1000);
            return deleteExtraProductNameSymbols(originalString);
        }

        public void ClickCurtButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[2]/ul/li[4]")).Click();
        }

        public string ClickAddToCartButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/div/button")).Click();

            /*try
            {
                driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div[2]/div[2]/div[1]/div/ul/li[1]/div")).Click();
            }
            catch (NoSuchElementException ex)
            {
                //TODO Add log msg // · Экстракт монарды СО2
            }*/

            Thread.Sleep(2000);
            string originalString = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[2]/div[3]/span[2]")).Text;

            return deleteExtraProductNameSymbols(originalString);
        }

        public string ClickLikeButton()
        {
            Thread.Sleep(2000);           
            driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[1]/button")).Click();

            //try
            //{
            //    driver.FindElement(By.XPath("/html/body/div[7]/div/div/div/div[2]/div[2]/div[1]/div/ul/li[1]/div")).Click();
            //}
            //catch (NoSuchElementException ex)
            //{
            //    //TODO Add log msg // · Экстракт монарды СО2
            //}

            Thread.Sleep(2000);
            string originalString = driver.FindElement(By.XPath("//*[@id=\"route-content\"]/div/section/div/div[1]/div/div[1]/div[1]/div/a/div[2]/div[3]/span[2]")).Text;

            return deleteExtraProductNameSymbols(originalString);
        }

        public void ClickfavouritesButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[2]/ul/li[2]")).Click();
        }

        public string deleteExtraProductNameSymbols(string originalString)
        {
            string stringWithoutDots = originalString.Replace(" · ", "");
            return stringWithoutDots;
        }

        public void ClickButton(By locator)
        {
            IWebElement elem = driver.FindElement(locator);

            Thread.Sleep(3000);

            elem.Click();
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
    }
}
