using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestFramework.Utilities;


namespace TestFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
           

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            _driver.Manage().Window.Maximize();


        }

        public void OpenBaseUrl()
        {
            _driver.Navigate().GoToUrl(ConfigurationHelper.BaseUrl);
        }

        public CareersPage GoToCareersPage()
        {
            var careersLink = _driver.FindElement(By.XPath("//a[@href='/careers' and contains(@class, 'top-navigation__item-link') and contains(@class, 'js-op')]"));
            careersLink.Click();

            return new CareersPage(_driver);
        }
        public void SearchForKeyword(string keyword)
        {
            var searchButton = _driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']"));
            searchButton.Click();

            var searchInput = _driver.FindElement(By.XPath("//input[@id='new_form_search']"));
            searchInput.Click();
            searchInput.SendKeys(keyword);

            var findButton = _driver.FindElement(By.XPath("//span[@class='bth-text-layer']"));
            findButton.Click();
        }

        public void PerformSearchAndVerifyResults()
        {
            OpenBaseUrl();

            var searchButton = _driver.FindElement(By.XPath("//span[contains(@class, 'search-icon') and contains(@class, 'dark-iconheader-search__search-icon')]"));
            searchButton.Click();

            var searchInput = _wait.Until(driver => driver.FindElement(By.CssSelector(".frequent-searches-ui-23")));

            var searchOption = _driver.FindElement(By.CssSelector(".frequent-searches__item"));
            searchOption.Click();

            var findButton = _wait.Until(driver => driver.FindElement(By.XPath("//button[contains(@class, 'custom-button') and contains(., 'Find')]")));
            findButton.Click();

            var viewMoreLink = _wait.Until(driver => driver.FindElement(By.XPath("//a[@href='#' and contains(@class, 'search-results__view-more') and contains(@class, 'button-text')]//span[contains(@class, 'search-results__view-more-text') and normalize-space()='View More']")));

            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight); arguments[0].scrollIntoView({behavior: 'smooth', block: 'center', inline: 'center'});", viewMoreLink);

            _wait.Until(driver => viewMoreLink.Displayed);

            var articles = _driver.FindElements(By.CssSelector(".search-results__item"));
            int numberOfArticles = articles.Count;

            Assert.AreEqual(20, numberOfArticles, "Number of articles is not as expected");

        }

        public void PerformLanguageDropdownCheck()
        {
            OpenBaseUrl();

            var languagesDropdown = _driver.FindElement(By.CssSelector(".location-selector__button"));
            languagesDropdown.Click();

            var languagesList = _wait.Until(driver => driver.FindElements(By.CssSelector(".location-selector__link")));

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

        public void PerformCareersLocationPageCheck()
        {
            OpenBaseUrl();

            var careersButton = _driver.FindElement(By.XPath("//*[@href = '/careers' and  contains(@class, 'top-navigation__item-link')]"));
            new Actions(_driver).MoveToElement(careersButton).Build().Perform();
            _driver.FindElement(By.XPath("//*[@href = '/careers/job-listings' and  contains(@class, 'top-navigation__main-link')]"))
                .Click();
            Assert.That(_driver.Url, Is.EqualTo("https://www.epam.com/careers/job-listings"), "Incorrect URL");
        }




    }
}
