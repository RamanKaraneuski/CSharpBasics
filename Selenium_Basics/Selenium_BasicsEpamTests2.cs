using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Web;

namespace Selenium_Basics
{

    [TestFixture]
    public class SeleniumBasicsTest
    {
        private IWebDriver driver;
        private const string BaseUrl = "https://www.epam.com";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestFindDreamJobCountries()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            driver.FindElement(By.XPath("//a[@href='/careers' and contains(@class, 'top-navigation__item-link') and contains(@class, 'js-op')]")).Click();
            driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-text']")).Click();
            driver.FindElement(By.XPath("(//*[name()='use'])[10]")).Click();

            bool americasDisplayed = driver.FindElement(By.XPath("//a[@data-item='0']")).Displayed;
            bool emeaDisplayed = driver.FindElement(By.XPath("//a[@data-item='1']")).Displayed;
            bool apacDisplayed = driver.FindElement(By.XPath("//a[@data-item='2']")).Displayed;

            Assert.IsTrue(americasDisplayed, "Americas not displayed");
            Assert.IsTrue(emeaDisplayed, "EMEA not displayed");
            Assert.IsTrue(apacDisplayed, "APAC not displayed");
        }



        [TestFixture]
        public class EpamSearchTestAutomation
        {
            private IWebDriver driver;
            private const string EpamUrl = "https://www.epam.com/";
            private const string SearchQuery = "Automation";
            private const int ExpectedNumberOfWordToSearch = 5;

            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }

            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }

            [Test]
            public void SearchAutomationKeywordOnEpamWebsite()
            {
                driver.Navigate().GoToUrl(EpamUrl);

                var searchButton = driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']"));
                searchButton.Click();

                Thread.Sleep(1000);

                var searchInput = driver.FindElement(By.XPath("//input[@id='new_form_search']"));
                searchInput.Click();
                searchInput.SendKeys(SearchQuery);

                var findButton = driver.FindElement(By.XPath("//span[@class='bth-text-layer']"));
                findButton.Click();

                var searchUrl = $"https://www.epam.com/search?q={SearchQuery}";
                Assert.AreEqual(searchUrl, driver.Url, "The URL is wrong");

                var searchResults = driver.FindElements(By.XPath("//div[@class='search-results__items']/article")).ToList();
                var actualNumberOfWordToSearch = searchResults.Count(p => p.Text.Contains(SearchQuery));
                Assert.That(actualNumberOfWordToSearch, Is.AtLeast(ExpectedNumberOfWordToSearch), "Request text repeated less than 5 times");
            }

        }

        [TestFixture]
        public class EpamSearchTestBusinessAnalysis
        {
            private IWebDriver driver;
            private const string EpamUrl = "https://www.epam.com/";
            private const string SearchQuery = "Business Analysis";

            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }

            [TearDown]
            public void TearDown()
            {
                driver.Quit();
            }

            [Test]
            public void SearchAutomationKeywordOnEpamWebsite()
            {
                driver.Navigate().GoToUrl(EpamUrl);

                var searchButton =
                    driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']"));
                searchButton.Click();

                Thread.Sleep(1000);

                var searchInput = driver.FindElement(By.XPath("//input[@id='new_form_search']"));
                searchInput.Click();
                searchInput.SendKeys(SearchQuery);

                var findButton = driver.FindElement(By.XPath("//span[@class='bth-text-layer']"));
                findButton.Click();

                var expectedUrl = $"https://www.epam.com/search?q={Uri.EscapeDataString(SearchQuery)}";
                var expectedDecodedUrl = HttpUtility.UrlDecode(expectedUrl);
                var actualDecodedUrl = HttpUtility.UrlDecode(driver.Url);

                Assert.AreEqual(expectedDecodedUrl, actualDecodedUrl, "The URL is wrong");

                var firstArticleLink = driver.FindElement(By.XPath("//a[@class='search-results__title-link'][1]"));
                var firstArticleTitle = firstArticleLink.Text;
                firstArticleLink.Click();

                var openedArticleTitleElement = driver.FindElement(By.XPath("//span[@class='museo-sans-light']"));
                var openedArticleTitle = openedArticleTitleElement.Text;

                Assert.AreEqual(firstArticleTitle, openedArticleTitle, "Titles are different");
            }
        }
    }

}
