using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaBooksForSchoolsPage : BasePage
    {
        private IWebElement FreeForTeachers => Driver.FindElement(By.LinkText("NEMOKAMA MEDŽIAGA MOKYTOJAMS"));
        public PresvikaBooksForSchoolsPage(IWebDriver webdriver) : base(webdriver) { }
        public void FreeForTeachersDownloadButton()
        {
            FreeForTeachers.Click();
        }
    }
}
