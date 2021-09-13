using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaHomePage : BasePage
    {
        private const string PageAddress = "https://www.presvika.lt/";
        private IWebElement AcceptCookies => Driver.FindElement(By.LinkText("Sutinku"));
        private IWebElement SearcInputField => Driver.FindElement(By.Id("main-search-input"));
        private IWebElement ClickButtonFromSixToSeven => Driver.FindElement(By.LinkText("6-7 metų vaikams"));
        private IWebElement SelecKidsButton => Driver.FindElement(By.CssSelector("#top_menu_link_1948 .a0"));
        private SelectElement SelectDropDown => new SelectElement(Driver.FindElement(By.Id("sortGoodsBy")));
        private IWebElement ScrooldownTillFindMagnetNumberSet => Driver.FindElement(By.CssSelector(".grid_12:nth-child(3) .item_hover_wrap_link > span"));
        private IWebElement OpenShoopingBagButton => Driver.FindElement(By.Id("cart-link"));
        private IWebElement ForScoolsButton => Driver.FindElement(By.LinkText("MOKYKLOMS"));
        private IWebElement LoserDiary => Driver.FindElement(By.CssSelector("#top_menu_link_1769 .a0"));
        private IWebElement LoserDiarySet => Driver.FindElement(By.CssSelector(".item_image_wrap_937 > .vv"));
        public PresvikaHomePage(IWebDriver webdriver) : base(webdriver) { }
        public void NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
        }
        public void Acceptcookies()
        {
            Cookie myCookie = new Cookie("cookieconsent_status", "dismiss", "www.presvika.lt", "/",
                                        System.DateTime.Now.AddDays(15));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();
        }
        public void SearchByText(string text)
        {
            SearcInputField.Clear();
            SearcInputField.SendKeys(text);
            SearcInputField.SendKeys(Keys.Enter);
        }
        public void SelectButtonKidsFrom6To7Years()
        {
            ClickButtonFromSixToSeven.Click();
        }
        public void SelectFromDropdownTop()
        {
            SelectDropDown.SelectByText("Pigiausios viršuje");
        }
        public void SelectFromDropdownHigestPrice()
        {
            SelectDropDown.SelectByText("Brangiausios viršuje");
        }
        public void SellectButtonKids()
        {
            SelecKidsButton.Click();
        }
        public void FindMagnetNumberSet()
        {
            ScrooldownTillFindMagnetNumberSet.Click();
        }
        public void OpenShoppingBag()
        {
            OpenShoopingBagButton.Click();
        }
        public void ClickForSchoolsButton()
        {
            ForScoolsButton.Click();
        }
        public void ChooseLoserDiary()
        {
            LoserDiary.Click();
            LoserDiarySet.Click();
        }
    }
}
