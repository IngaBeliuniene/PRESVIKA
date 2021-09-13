using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Presvika_baigiamasis.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;
        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public WebDriverWait GetWait(IWebDriver driver, int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
            return wait;
        }
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
