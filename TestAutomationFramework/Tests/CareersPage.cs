using OpenQA.Selenium;

namespace TestFramework.Pages
{
    public class CareersPage
    {
        private IWebDriver _driver;

        public CareersPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickCareersLink()
        {
            var careersLink = _driver.FindElement(By.XPath("//*[text()='Careers']//ancestor::*[@class='top-navigation__item-text']"));
            careersLink.Click();
        }

        public void ClickDreamJobIcon()
        {
            var dreamJobIcon = _driver.FindElement(By.XPath("(//*[name()='use'])[10]"));
            dreamJobIcon.Click();
        }

        public bool IsAmericasDisplayed()
        {
            var americasLink = _driver.FindElement(By.XPath("//a[@data-item='0']"));
            return americasLink.Displayed;
        }

        public bool IsEMEADisplayed()
        {
            var emeaLink = _driver.FindElement(By.XPath("//a[@data-item='1']"));
            return emeaLink.Displayed;
        }

        public bool IsAPACDisplayed()
        {
            var apacLink = _driver.FindElement(By.XPath("//a[@data-item='2']"));
            return apacLink.Displayed;
        }
    }
}