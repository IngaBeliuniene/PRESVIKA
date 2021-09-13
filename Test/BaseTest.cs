using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Presvika_baigiamasis.Driver;
using Presvika_baigiamasis.Page;
using Presvika_baigiamasis.Tools;

namespace Presvika_baigiamasis.Test
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public static PresvikaHomePage _presvikaHomePage;
        public static PresvikaSearchByTextResultPage _presvikaSearchResultPage;
        public static PresvikaShoppingBagPage _presvikaShoppingBagPage;
        public static PresvikaCheapestOrderPage _presvikaCheapestTopPage;
        public static PresvikaMagnetNumberSetPage _presvikamagnetNumberSetPage;
        public static PresvikaBooksForSchoolsPage _presvikaForSchoolsPage;
        public static PresvikaDownloadsForTeacherPage _presvikaDownloadsForTeacherPage;
        public static PresvikaLoserDiaryBookPage _presvikaLoserDiaryPage;
        public static BaseTest baseTest;

        [OneTimeSetUp]
        public static void SetUp()
        {
            driver = CustomDriver.GetIncognitoFirefox();
        
            _presvikaHomePage = new PresvikaHomePage(driver);
            _presvikaSearchResultPage = new PresvikaSearchByTextResultPage(driver);
            _presvikaShoppingBagPage = new PresvikaShoppingBagPage(driver);
            _presvikaCheapestTopPage = new PresvikaCheapestOrderPage(driver);
            _presvikamagnetNumberSetPage = new PresvikaMagnetNumberSetPage(driver);
            _presvikaForSchoolsPage = new PresvikaBooksForSchoolsPage(driver);
            _presvikaDownloadsForTeacherPage = new PresvikaDownloadsForTeacherPage(driver);
            _presvikaLoserDiaryPage = new PresvikaLoserDiaryBookPage(driver);
        }
        [TearDown]
        public static void TakeScreeshot()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                PresvikaMyScreenshot.TakeScreeshot(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
    }
}
