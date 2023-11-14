using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text;

namespace Lab9
{
    public class Tests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.wildberries.by/";
            verificationErrors = new StringBuilder();

        }

        [TearDown]
        public void TearDownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Assert.That(verificationErrors.ToString(), Is.EqualTo(""));
        }

        [Test]
        public void TestAddItemToBasket()
        {
            driver.Navigate().GoToUrl(baseURL);

            Thread.Sleep(5000);

            IWebElement search = driver.FindElement(By.XPath("//*[@id=\"wbx-app\"]/header/div[1]/div[2]/div/div/div[1]/div/input"));

            search.SendKeys("футболка");

            search.SendKeys(Keys.Enter);


            Thread.Sleep(3000);
            Assert.AreEqual(driver.Title, "футболка");

            Thread.Sleep(2000);
        }
    }
}