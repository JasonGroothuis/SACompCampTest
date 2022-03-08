using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SACodeCampTest.models;

namespace SACodeCampTest
{
    [TestClass]
    public class PizzaHQTest
    {
        IWebDriver driver;
        const string homePageUrl = "https://d2ju5vf8ca0qio.cloudfront.net/#/";

        HomePage homePage;
        ContactPage contactPage;
        MenuPage menuPage;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            homePage = new(driver, homePageUrl);
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

        [TestMethod]
        public void VerifyRequiredContactFields()
        {
            homePage.ClickContact();
            contactPage = new(driver);
            Assert.IsTrue(contactPage.ClickSubmitRequiredShows());
        }

        [TestMethod]
        public void VerifyForenameEnteredNoError()
        {
            homePage.ClickContact();
            contactPage = new(driver);
            Assert.IsTrue(contactPage.ForenameEnteredNoError());
        }
        [TestMethod]
        public void VerifyEmailEnteredNoError()
        {
            homePage.ClickContact();
            contactPage = new(driver);
            Assert.IsTrue(contactPage.EmailEnteredNoError());
        }
        [TestMethod]
        public void VerifyMessageEnteredNoError()
        {
            homePage.ClickContact();
            contactPage = new(driver);
            Assert.IsTrue(contactPage.messageEnteredNoError());
        }

        [TestMethod]
        public void VerifyVeganMenuPrices()
        {
            homePage.ClickMenu();
            menuPage = new(driver);
            // Vegan Price check not working yet;
            Assert.IsTrue(menuPage.VeganPizzaPricesOK());
        }


    }
}
