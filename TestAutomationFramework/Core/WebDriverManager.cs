using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework.Core
{
    public static class WebDriverManager
    {
        private static IWebDriver _driver;

        // Метод для инициализации веб-драйвера
        public static void Initialize()
        {
            _driver = new ChromeDriver(); // Используем ChromeDriver, можно заменить на другой
        }

        // Свойство для доступа к веб-драйверу
        public static IWebDriver Driver
        {
            get { return _driver; }
        }

        // Метод для завершения работы с веб-драйвером
        public static void Quit()
        {
            _driver.Quit();
        }


    }
}


//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;

//namespace TestFramework.Core
//{
//    public static class WebDriverManager
//    {
//        private static IWebDriver _driver;

//        public static IWebDriver Driver
//        {
//            get
//            {
//                if (_driver == null)
//                    throw new NullReferenceException(
//                        "WebDriver is not initialized. Call WebDriverManager.Initialize() first.");
//                return _driver;
//            }
//        }

//        public static void Initialize()
//        {
//            _driver = new ChromeDriver();
//            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            _driver.Manage().Window.Maximize();
//        }

//        public static void Quit()
//        {
//            _driver.Quit();
//            _driver = null;
//        }
//    }

//    public class BasePage
//    {
//        protected IWebDriver Driver;

//        public BasePage(IWebDriver driver)
//        {
//            Driver = driver;
//        }
//    }

//    public class LoginPage : BasePage
//    {
//        private const string BaseUrl = "https://www.epam.com/";

//        public LoginPage(IWebDriver driver) : base(driver)
//        {
//        }

//        public void OpenBaseUrl()
//        {
//            Driver.Navigate().GoToUrl(BaseUrl);
//        }

//        public CareersPage NavigateToCareersPage()
//        {
//            var careersLink = Driver.FindElement(By.XPath(
//                "//a[@href='/careers' and contains(@class, 'top-navigation__item-link') and contains(@class, 'js-op')]"));
//            careersLink.Click();

//            var careersTextLink =
//                Driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-text']"));
//            careersTextLink.Click();

//            return new CareersPage(Driver);
//        }

//        public SearchResultsPage PerformSearch(string searchTerm)
//        {
//            var searchButton =
//                Driver.FindElement(By.XPath("//div[@class='header-search-ui header-search-ui-23 header__control']"));
//            searchButton.Click();

//            var searchInput = Driver.FindElement(By.XPath("//input[@id='new_form_search']"));
//            searchInput.Click();
//            searchInput.SendKeys(searchTerm);

//            var findButton = Driver.FindElement(By.XPath("//span[@class='bth-text-layer']"));
//            findButton.Click();

//            return new SearchResultsPage(Driver);
//        }
//    }

//    public class CareersPage : BasePage
//    {
//        public CareersPage(IWebDriver driver) : base(driver)
//        {
//        }

//        public DreamJobPage NavigateToDreamJobPage()
//        {
//            var dreamJobLink = Driver.FindElement(By.XPath("(//*[name()='use'])[10]"));
//            dreamJobLink.Click();

//            return new DreamJobPage(Driver);
//        }
//    }

//    public class DreamJobPage : BasePage
//    {
//        public DreamJobPage(IWebDriver driver) : base(driver)
//        {
//        }

//        public bool IsAmericasLinkDisplayed()
//        {
//            return Driver.FindElement(By.XPath("//a[@data-item='0']")).Displayed;
//        }

//        public bool IsEMEALinkDisplayed()
//        {
//            return Driver.FindElement(By.XPath("//a[@data-item='1']")).Displayed;
//        }

//        public bool IsAPACLinkDisplayed()
//        {
//            return Driver.FindElement(By.XPath("//a[@data-item='2']")).Displayed;
//        }
//    }

//    public class SearchResultsPage : BasePage
//    {
//        public SearchResultsPage(IWebDriver driver) : base(driver)
//        {
//        }

//        public int GetNumberOfSearchResults(string searchTerm)
//        {
//            var searchResults = Driver.FindElements(By.XPath("//div[@class='search-results__items']/article")).ToList();
//            return searchResults.Count(p => p.Text.Contains(searchTerm));
//        }

//        public string GetFirstArticleTitle()
//        {
//            var firstArticleLink = Driver.FindElement(By.XPath("//a[@class='search-results__title-link'][1]"));
//            return firstArticleLink.Text;
//        }

//        public string OpenFirstArticle()
//        {
//            var firstArticleLink = Driver.FindElement(By.XPath("//a[@class='search-results__title-link'][1]"));
//            string firstArticleTitle = firstArticleLink.Text;
//            firstArticleLink.Click();
//            return firstArticleTitle;
//        }
//    }
//}