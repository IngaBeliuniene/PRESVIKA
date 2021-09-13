using NUnit.Framework;
using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaDownloadsForTeacherPage : BasePage
    {
        private IWebElement DownloadButtonClick => Driver.FindElement(By.LinkText("Atsisiųsti"));
        private IWebElement ResultDownload => Driver.FindElement(By.CssSelector("h1"));
        public PresvikaDownloadsForTeacherPage(IWebDriver webdriver) : base(webdriver) { }
        public void FirstBookDownloadButton()
        {
            DownloadButtonClick.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.history.go(-1)");
        }
        public void VerifyDownloadBook(string text)
        {
            Assert.AreEqual(text, ResultDownload.Text, "Can't Download book");
        }
    }
}
