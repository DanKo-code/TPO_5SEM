using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace MyWebSiteCaseTests.Tests
{
    public class WildTests
    {
        [Test]
        public void SwitchProductTest()
        {
            HomePage wildPage = new HomePage(new ChromeDriver());

            wildPage.GoToPage();

            Thread.Sleep(5000);

            wildPage.SearchProduct("Футболка");


            Thread.Sleep(3000);

            string searchResult = wildPage.GetSearchResult();

            Thread.Sleep(1000);
            wildPage.Exit();

            Assert.AreEqual(searchResult, "футболка");
        }

        [Test]
        public void checkCommentsContainer()
        {
            HomePage wildPage = new HomePage(new ChromeDriver());

            wildPage.GoToPage();

            Thread.Sleep(5000);

            wildPage.ClickButton(By.XPath("//*[@id=\"route-content\"]/div/section[1]/div/div[1]/div[1]"));

            bool existElement = wildPage.checkExistanceElement(By.XPath("//*[@id=\"route-content\"]/div/div[1]/div[1]/div[4]/div/div[2]/section[4]/div/div"));



            Thread.Sleep(1000);
            wildPage.Exit();

            Assert.IsTrue(existElement, "Элемент не найден");
        }
    }
}