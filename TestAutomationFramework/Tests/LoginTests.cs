using NUnit.Framework;
using OpenQA.Selenium;
using TestFramework.Core;
using TestFramework.Pages;
using TestFramework.Utilities;
using NUnit.Framework;

namespace Selenium_Advanced
{
    [TestFixture]
    public class Selenium_AdvancedTest3
    {
        [SetUp]
        public void Setup()
        {
            WebDriverManager.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.Quit();
        }

        [Test]
        public void SearchAndVerifyResults()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.PerformSearchAndVerifyResults();
        }
    }


    [TestFixture]
    public class Selenium_AdvancedTest2
    {
        [SetUp]
        public void Setup()
        {
            WebDriverManager.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.Quit();
        }

        [Test]
        public void CheckLanguageDropdown()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.PerformLanguageDropdownCheck();
        }
    }

    [TestFixture]
    public class Selenium_AdvancedTest1
    {
        [SetUp]
        public void Setup()
        {
            WebDriverManager.Initialize();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverManager.Quit();
        }

        [Test]
        public void CheckCareersLocationPage()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.PerformCareersLocationPageCheck();
        }
    }

    [TestFixture]
    public class EpamTests
    {
        [SetUp]
        public void Setup()
        {
            WebDriverManager.Initialize();
        }

        [TearDown]
        public void Teardown()
        {
            WebDriverManager.Quit();
        }

        [Test]
        public void OpenEpamHomePage()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.OpenBaseUrl();

            Assert.AreEqual(ConfigurationHelper.BaseUrl, WebDriverManager.Driver.Url);
        }

        [Test]
        public void NavigationAndPageReload()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.OpenBaseUrl();

            var howWeDoItUrl = ConfigurationHelper.BaseUrl + "services";
            var ourWorkUrl = ConfigurationHelper.BaseUrl + "/services/client-work";

            WebDriverManager.Driver.Navigate().GoToUrl(howWeDoItUrl);
            WebDriverManager.Driver.Navigate().GoToUrl(ourWorkUrl);
            WebDriverManager.Driver.Navigate().Refresh();
            WebDriverManager.Driver.Navigate().Back();

            Assert.AreEqual(howWeDoItUrl, WebDriverManager.Driver.Url);
        }



        [Test]
        public void NavigationAndPageReloadClick()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.OpenBaseUrl();

           
            var howWeDoItUrl = ConfigurationHelper.BaseUrl + "services";

            var exploreOurClientWorkLocator = By.XPath("//a[contains(@class, 'bold-underlined-hover') and @href='/services/client-work']");

            WebDriverManager.Driver.Navigate().GoToUrl(howWeDoItUrl);
            WebDriverManager.Driver.FindElement(exploreOurClientWorkLocator).Click();
            WebDriverManager.Driver.Navigate().Refresh();
            WebDriverManager.Driver.Navigate().Back();

            Assert.AreEqual(howWeDoItUrl, WebDriverManager.Driver.Url);
        }


        [Test]
        public void TestFindDreamJobCountries()
        {
            var loginPage = new LoginPage(WebDriverManager.Driver);
            loginPage.OpenBaseUrl();

            var careersPage = loginPage.GoToCareersPage();
            careersPage.ClickCareersLink();
            careersPage.ClickDreamJobIcon();

            Assert.IsTrue(careersPage.IsAmericasDisplayed(), "Americas not displayed");
            Assert.IsTrue(careersPage.IsEMEADisplayed(), "EMEA not displayed");
            Assert.IsTrue(careersPage.IsAPACDisplayed(), "APAC not displayed");
        }


    }