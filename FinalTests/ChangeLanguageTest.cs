using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace FinalTests
{
    [TestFixture]
    public class ChangeLanguageTest
    {
        private IWebDriver driver;

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

        [TestCase("English")]
        [TestCase("Русский")]
        [TestCase("Українська")]
        public void ChangeLanguageAndVerify(string language)
        {
            driver.Navigate().GoToUrl("https://training.by");

            IWebElement russianLanguageButton = driver.FindElement(By.XPath("(//button[@class='Button-module_container__XGXQ0 uui-button-box uui-enabled -clickable MainMenuButton-module_root__pJ8X7 MainMenuButton-module_type-primary__8AIyW'])[1]"));
            russianLanguageButton.Click();

            IWebElement languageOption = driver.FindElement(By.XPath($"//div[@class='styles_locale-switch-dropdown_item__OeQfh' and text()='{language}']"));
            languageOption.Click();

            System.Threading.Thread.Sleep(1000);

            IWebElement selectedLanguage = driver.FindElement(By.XPath("//button[@class='Button-module_container__XGXQ0 uui-button-box uui-enabled -clickable MainMenuButton-module_root__pJ8X7 MainMenuButton-module_type-primary__8AIyW']"));
            Assert.IsTrue(selectedLanguage.Text.Contains(language));
        }
    }
}