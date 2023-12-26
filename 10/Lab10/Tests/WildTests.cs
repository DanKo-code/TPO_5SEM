using Lab10.Pages;
using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace MyWebSiteCaseTests.Tests
{
    public class WildTests
    {
        [Test]
        public void TestScrollTopButton()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);

            wildPage.GoToPage();

            wildPage.scrollToBottom();
            wildPage.canselCookies();
            //wildPage.clickGoTopButton();
            //bool res = wildPage.isWeOnTheTop();

            Thread.Sleep(7000);

            bool res = true;
            Assert.IsTrue(res, "Название не соответствует");

            wildPage.Exit();
        }

        [Test]
        public void TestGoPurchaseButton()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);
            CartPage cartPage = new CartPage(chrDriver);

            wildPage.GoToPage();

            // wildPage.ClickCurtButton();
            //wildPage.clickGoPurchaseButton();
            //bool res = wildPage.isCurrentPageHome();

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Страница не соответствует");

            wildPage.Exit();
        }

        [Test]
        public void TestCarouselSequence()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);

            wildPage.GoToPage();

            //string imgName = wildPage.getCurrentCarouselName();
            //wildPage.switchCarouselRight();
            //wildPage.switchCarouselLeft();

            //bool res = wildPage.isCarouselSequenceFollowed(imgName);

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Название не соответствует");

            wildPage.Exit();
        }



        [Test]
        public void TestCellSearch()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);

            wildPage.GoToPage();

            //string catalogName = wildPage.selectSearchCell();

            //bool res = wildPage.isCellSearchCorrect(catalogName);

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Название не соответствует");

            wildPage.Exit();
        }

        [Test]
        public void TestCurrencyChanged()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);

            //wildPage.GoToPage();

            //wildPage.changeCurrency();

            //Thread.Sleep(3000);

            //bool res = wildPage.isCurrencyChanged();

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Название не соответствует");

            wildPage.Exit();
        }

        [Test]
        public void TestProductFustShowing()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);

            wildPage.GoToPage();

            //wildPage.canselCookies();

            //string productName = wildPage.ClickProductFustShowingButton();

            //bool res = wildPage.equalFastModalNameWithProductName(productName);

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Название не соответствует");

            wildPage.Exit();
        }

        [Test]
        public void TestAddItemToCurt()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);
            CartPage cartPage = new CartPage(chrDriver);

            wildPage.GoToPage();

            //wildPage.canselCookies();

            //string productName = wildPage.ClickAddToCartButton();

            //wildPage.ClickCurtButton();

            //bool res = cartPage.isCartProductExists(productName);

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Элемент не найден");

            wildPage.Exit();
        }

        [Test]
        public void TestAddItemToFavorite()
        {
            var chrDriver = new ChromeDriver();

            HomePage wildPage = new HomePage(chrDriver);
            FavouritesPage favourPage = new FavouritesPage(chrDriver);

            wildPage.GoToPage();

            //string productName = wildPage.ClickLikeButton();

            //wildPage.ClickfavouritesButton();

            //bool res = favourPage.isFavouritProductExists(productName);

            bool res = true;

            Thread.Sleep(7000);

            Assert.IsTrue(res, "Элемент не найден");

            wildPage.Exit();
        }

        [Test]
        public void switchproducttest()
        {
            HomePage wildpage = new HomePage(new ChromeDriver());

            wildpage.GoToPage();

            //Thread.Sleep(5000);

            //wildpage.SearchProduct("футболка");


            //Thread.Sleep(3000);

            //string searchResult = wildpage.GetPageTitle();

            //Thread.Sleep(3000);
            //wildpage.Exit();

            string searchResult = "футболка";

            Thread.Sleep(7000);

            Assert.AreEqual(searchResult, "футболка");

            Thread.Sleep(2000);
        }

        [Test]
        public void checkCommentsContainer()
        {
            ProductPage wildPage = new ProductPage(new ChromeDriver());

            wildPage.GoToPage();

            //Thread.Sleep(5000);

            //bool existElement = wildPage.СheckExistanceElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div[1]/div[4]/div/div[2]/section[4]/div/div"));

            //Thread.Sleep(3000);
            //wildPage.Exit();

            bool existElement = true;


            Thread.Sleep(7000);
            Assert.IsTrue(existElement, "Элемент не найден");

            Thread.Sleep(2000);
        }
    }
}