using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaSearchByTextResultPage : BasePage
    {
        private IWebElement FindBook => Driver.FindElement(By.CssSelector(".item_image_wrap_1727 > .vv"));
        private IWebElement ItemInputField => Driver.FindElement(By.Id("add_to_cart_qty_1727"));
        private IWebElement ShopingBagButtonIcon => Driver.FindElement(By.CssSelector(".addCart > strong"));
        public PresvikaSearchByTextResultPage(IWebDriver webdriver) : base(webdriver) { }
        public void SelectBookFromResults()
        {
            FindBook.Click();
        }
        public void OpenAndAddInputQuantity()
        {
            ItemInputField.Clear();
            ItemInputField.SendKeys("10");
        }
        public void ClickSelectShopingBagButton()
        {
            ShopingBagButtonIcon.Click();
        }
    }
}
