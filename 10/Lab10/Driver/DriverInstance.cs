using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Driver
{
    public class DriverInstance
    {
        private static IWebDriver driver;

        private DriverInstance() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
            }
            return driver;
        }

        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }
    }
}
