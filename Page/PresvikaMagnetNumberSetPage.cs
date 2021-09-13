using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaMagnetNumberSetPage : BasePage
    {
        private IWebElement QuantityInputField => Driver.FindElement((By.Id("add_to_cart_qty_1145")));
        private IWebElement ShopingBagButtonIcon => Driver.FindElement(By.CssSelector(".addCart > strong"));
        public PresvikaMagnetNumberSetPage(IWebDriver webdriver) : base(webdriver) { }
        public void MagnetInputFieldInputQuantity()
        {
            QuantityInputField.Clear();
            QuantityInputField.SendKeys("2");
        }
        public void ClickSelectShopingBagIconButton()
        {
            ShopingBagButtonIcon.Click();
        }
    }
}

