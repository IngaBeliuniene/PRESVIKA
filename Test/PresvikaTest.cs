using NUnit.Framework;

namespace Presvika_baigiamasis.Test
{
    public class PresvikaTest : BaseTest
    {
        [Test]
        public static void TestCheaperPriceBuyingTenBooks()
        {
            _presvikaHomePage.NavigateToPage();
            _presvikaHomePage.Acceptcookies();
            _presvikaHomePage.SearchByText("pirmieji zodziai");
            _presvikaSearchResultPage.SelectBookFromResults();
            _presvikaSearchResultPage.OpenAndAddInputQuantity();
            _presvikaSearchResultPage.ClickSelectShopingBagButton();
            _presvikaHomePage.OpenShoppingBag();
            _presvikaShoppingBagPage.VerifyResultSumWithDiscount("45.50€");
        }
        [Test]
        public static void TestDownloadBookForTeachers()
        {
            _presvikaHomePage.NavigateToPage();
            _presvikaHomePage.Acceptcookies();
            _presvikaHomePage.ClickForSchoolsButton();
            _presvikaForSchoolsPage.FreeForTeachersDownloadButton();
            _presvikaDownloadsForTeacherPage.FirstBookDownloadButton();
            _presvikaDownloadsForTeacherPage.VerifyDownloadBook("Čia galite nemokamai atsisiųsti:");
        }
        [Test]
        public static void TestFreeDeliveryBuyingTwoUnitsMostExpensiveBooksKids()
        {
            _presvikaHomePage.NavigateToPage();
            _presvikaHomePage.Acceptcookies();
            _presvikaHomePage.OpenShoppingBag();
            _presvikaShoppingBagPage.ClearShoppingBagInfo();
            _presvikaHomePage.SellectButtonKids();
            _presvikaHomePage.SelectFromDropdownHigestPrice();
            _presvikaHomePage.FindMagnetNumberSet();
            _presvikamagnetNumberSetPage.MagnetInputFieldInputQuantity();
            _presvikamagnetNumberSetPage.ClickSelectShopingBagIconButton();
            _presvikaHomePage.OpenShoppingBag();
            _presvikaShoppingBagPage.VerifyFreeDelivery("Pristatysime nemokamai!");
        }
        [Test]
        public static void TestMinimalOrderSumTextInformation()
        {
            _presvikaHomePage.NavigateToPage();
            _presvikaHomePage.Acceptcookies();
            _presvikaHomePage.OpenShoppingBag();
            _presvikaShoppingBagPage.ClearShoppingBagInfo();
            _presvikaHomePage.SellectButtonKids();
            _presvikaHomePage.SelectButtonKidsFrom6To7Years();
            _presvikaHomePage.SelectFromDropdownTop();
            _presvikaCheapestTopPage.AddToShoppingBagBook();
            _presvikaHomePage.OpenShoppingBag();
            _presvikaShoppingBagPage.VerifyResultMinimalOrderText("Jūsų užsakymas nesiekia minimalios 1.00 € sumos " +
                                                                       "(neskaičiuojant pristatymo kainos). Iki jos Jums trūksta 0.21 €.");
        }
        [Test]
        public static void TestWriteComentAftersSelectedItem()
        {
            _presvikaHomePage.NavigateToPage();
            _presvikaHomePage.Acceptcookies();
            _presvikaHomePage.ChooseLoserDiary();
            _presvikaLoserDiaryPage.CommentsButton();
            _presvikaLoserDiaryPage.GiveEvaluationFiveStars();
            _presvikaLoserDiaryPage.FillInUserInformationField("anonimas");
            _presvikaLoserDiaryPage.WriteComment("puikios");
            _presvikaLoserDiaryPage.VerifyCommentResult("puikios");
        }
    }
}
