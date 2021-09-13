using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Presvika_baigiamasis.Page
{
    public class PresvikaLoserDiaryBookPage : BasePage
    {
        private IWebElement Comments => Driver.FindElement(By.LinkText("Komentarai"));
        private IWebElement EvaluationFiveStars => Driver.FindElement(By.CssSelector(".db:nth-child(5) span"));
        private IWebElement NameInputField => Driver.FindElement(By.Name("name"));
        private IWebElement CommentTextArea => Driver.FindElement(By.Id("comment_textarea"));
        private IWebElement CommentButton => Driver.FindElement(By.XPath("//a[@class='btn1 fl submit-button a0']"));
        private IWebElement SeeComment => Driver.FindElement(By.CssSelector(".grid_46:nth-child(1) > .grid_46"));
        public PresvikaLoserDiaryBookPage(IWebDriver webdriver) : base(webdriver) { }
        public void CommentsButton()
        {
            Comments.Click();
        }
        public void GiveEvaluationFiveStars()
        {
            EvaluationFiveStars.Click();
        }
        public void FillInUserInformationField(string text)
        {
            NameInputField.Clear();
            NameInputField.SendKeys(text);

        }
        public void WriteComment(string text)
        {
            CommentTextArea.Clear();
            CommentTextArea.SendKeys(text);
            CommentButton.Click();
        }
        public void VerifyCommentResult(string comment)
        {
            Assert.AreEqual(comment, SeeComment.Text, "no cooment");
        }
    }
}
