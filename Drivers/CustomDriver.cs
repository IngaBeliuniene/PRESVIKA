using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Presvika_baigiamasis.Driver

{
    public class CustomDriver
    {
        public static IWebDriver GetIncognitoChrome1()
        {
            return GetDriver(Browsers.Chrome);
        }
        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }
        public static IWebDriver GetIncognitoFirefox()
        {
            return GetDriver(Browsers.IncognitoFirefox);
        }
        public static IWebDriver GetIncognitoChrome()
        {
            return GetDriver(Browsers.IncognitoChrome);
        }
        private static IWebDriver GetDriver(Browsers browserName)
        {
            IWebDriver driver = null;
            switch (browserName)
            {
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.IncognitoFirefox:
                    driver = GetFirefoxWithIncognitoOptions();
                    break;
                case Browsers.IncognitoChrome:
                    driver = GetChromeWithIncognitoOptions();
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
        private static IWebDriver GetFirefoxWithIncognitoOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("incognito");
            return new FirefoxDriver(options);
        }
        private static IWebDriver GetChromeWithIncognitoOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            return new ChromeDriver(options);
        }
    }
}
