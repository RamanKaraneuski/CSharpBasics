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





}