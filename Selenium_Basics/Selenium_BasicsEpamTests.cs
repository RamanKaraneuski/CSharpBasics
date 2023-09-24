using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace Selenium_Basics
{
    [TestFixture]
    public class EpamTests
    {
        private IWebDriver driver;
        private const string BaseUrl = "https://www.epam.com/";
        private const string HowWeDoItUrl = BaseUrl + "services";
        private const string OurWorkUrl = BaseUrl + "/services/client-work";

        private By ExploreOurClientWorkLocator = By.XPath("//a[contains(@class, 'bold-underlined-hover') and @href='/services/client-work']");
      
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

        [Test]
        public void OpenEpamHomePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);

            Assert.AreEqual(BaseUrl, driver.Url);
        }

        [Test]
        public void NavigationAndPageReload()
        {
            driver.Navigate().GoToUrl(HowWeDoItUrl);

            driver.Navigate().GoToUrl(OurWorkUrl);

            driver.Navigate().Refresh();

            driver.Navigate().Back();

            Assert.AreEqual(HowWeDoItUrl, driver.Url);
        }

        [Test]
        public void NavigationAndPageReloadClick()
        {
            driver.Navigate().GoToUrl(HowWeDoItUrl);

            driver.FindElement(ExploreOurClientWorkLocator).Click();

            driver.Navigate().Refresh();

            driver.Navigate().Back();

            Assert.AreEqual(HowWeDoItUrl, driver.Url);
        }
    }
}