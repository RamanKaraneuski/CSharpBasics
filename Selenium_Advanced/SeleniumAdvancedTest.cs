using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Selenium_Advanced
{
    [TestFixture]
    public class Selenium_AdvancedTest3
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void SearchAndVerifyResults()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/");

            var searchButton = driver.FindElement(By.XPath("//span[contains(@class, 'search-icon') and contains(@class, 'dark-iconheader-search__search-icon')]"));
            searchButton.Click();

            var searchInput = wait.Until(driver => driver.FindElement(By.CssSelector(".frequent-searches-ui-23")));

            var searchOption = driver.FindElement(By.CssSelector(".frequent-searches__item"));
            searchOption.Click();

            var findButton = wait.Until(driver => driver.FindElement(By.XPath("//button[contains(@class, 'custom-button') and contains(., 'Find')]")));
            findButton.Click();

            var viewMoreLink = wait.Until(driver => driver.FindElement(By.XPath("//a[@href='#' and contains(@class, 'search-results__view-more') and contains(@class, 'button-text')]//span[contains(@class, 'search-results__view-more-text') and normalize-space()='View More']")));

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight); arguments[0].scrollIntoView({behavior: 'smooth', block: 'center', inline: 'center'});", viewMoreLink);

            wait.Until(driver => viewMoreLink.Displayed);

            var articles = driver.FindElements(By.CssSelector(".search-results__item"));
            int numberOfArticles = articles.Count;

            Assert.AreEqual(20, numberOfArticles, "Number of articles is not as expected");
        }
    }

    [TestFixture]
    public class Selenium_AdvancedTest2
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void CheckLanguageDropdown()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/");

            var languagesDropdown = driver.FindElement(By.CssSelector(".location-selector__button"));
            languagesDropdown.Click();

            var languagesList = wait.Until(driver => driver.FindElements(By.CssSelector(".location-selector__link")));

            string[] expectedLanguages = { "Global (English)", "Hungary (English)", "СНГ (Русский)", "Česká Republika (Čeština)", "India (English)", "Україна (Українська)", "Czech Republic (English)", "日本 (日本語)", "中国 (中文)", "DACH (Deutsch)", "Polska (Polski)" };

            Console.WriteLine("Number of languages in list: " + languagesList.Count);

            foreach (var languageElement in languagesList)
            {
                Console.WriteLine("Element Text: " + languageElement.Text);
            }

            for (int i = 0; i < expectedLanguages.Length; i++)
            {
                Assert.AreEqual(expectedLanguages[i], languagesList[i].Text, "Language mismatch");
            }
        }
    }

    [TestFixture]
    public class Selenium_AdvancedTest1
    {
        private IWebDriver driver;
        private Actions action;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            action = new Actions(driver);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void CheckCareersLocationPage()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/");
            var careersButton = driver.FindElement(By.XPath("//*[@href = '/careers' and  contains(@class, 'top-navigation__item-link')]"));
            action.MoveToElement(careersButton).Build().Perform();
            driver.FindElement(By.XPath("//*[@href = '/careers/job-listings' and  contains(@class, 'top-navigation__main-link')]")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://www.epam.com/careers/job-listings"), "Incorrect URL");
        }
    }
}