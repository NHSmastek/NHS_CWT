using CWTTestFramework.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CWTTestFramework
{
    public class Driver
    {
        static IWebDriver webDriver;

        public static void Initialize(string webBrowser)
        {
            string driverPath = @".\\Drivers";

            switch (webBrowser)
            {
                case Browser.Firefox: webDriver = new FirefoxDriver(driverPath); break;
                case Browser.IE: webDriver = new InternetExplorerDriver(driverPath); break;
                case Browser.Chrome: webDriver = new ChromeDriver(driverPath); break;
                default: webDriver = new ChromeDriver(driverPath); break;
            }
        }

        public static string Title
        {
            get
            {
                return webDriver.Title;
            }
        }

        public static ISearchContext MyWebDriver
        {
            get { return webDriver; }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        internal static void GoTo(string url)
        {
            webDriver.Url = url;
        }
    }
}
