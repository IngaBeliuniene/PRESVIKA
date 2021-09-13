using NUnit.Framework;
using OpenQA.Selenium;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaShoppingBagPage : BasePage
    {
        IWebElement ResultSum => Driver.FindElement(By.CssSelector(".c1 > strong"));
        private IWebElement ResultOfMinimalSum => Driver.FindElement(By.CssSelector(".warning"));
        private IWebElement InformationFieldAboutFreeDelivery => Driver.FindElement(By.CssSelector("#header .delivery_free > .free_delivery_lbl"));
        private IWebElement ClearShoppingBag => Driver.FindElement(By.CssSelector(".grid-7 > .delete_cart_item"));

        public PresvikaShoppingBagPage(IWebDriver webdriver) : base(webdriver) { }
        public void VerifyResultSumWithDiscount(string price)
        {
            Assert.AreEqual(price, ResultSum.Text.Insert(2, "."), "Wrong sum, no discount When buying 10 books");
        }
        public void VerifyResultMinimalOrderText(string text)
        {
            Assert.AreEqual(text, ResultOfMinimalSum.Text, "Wrong text about minimal order sum");
        }
        public void VerifyFreeDelivery(string text)
        {
            Assert.AreEqual(text, InformationFieldAboutFreeDelivery.Text, "wrong message");
        }
        public void ClearShoppingBagInfo()
        {
            ClearShoppingBag.Click();
            var alert_win = Driver.SwitchTo().Alert();

            alert_win.Accept();
        }
    }
}


