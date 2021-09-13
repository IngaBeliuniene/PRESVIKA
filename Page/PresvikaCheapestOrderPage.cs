using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaCheapestOrderPage : BasePage
    {
        private IWebElement SelectShoppingBagButtonAfterFirstBook => Driver.FindElement(By.CssSelector(".add_to_cart_369 strong"));
        public PresvikaCheapestOrderPage(IWebDriver webdriver) : base(webdriver) { }
        public void AddToShoppingBagBook()
        {
            SelectShoppingBagButtonAfterFirstBook.Click();
        }
    }
}
