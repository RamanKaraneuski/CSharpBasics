using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTests
{
    [TestFixture]
    public class TaskFourLEARNMORE
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

        [Test]
        public void CheckLearnMoreButtonExists()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/careers");

            IWebElement learnMoreButton = driver.FindElement(By.XPath("//a[contains(@class, 'button-ui-23') and contains(@href, '/about/newsroom/press-releases/2022/epam-launches-ukraine-assistance-fund')]"));

            Assert.IsNotNull(learnMoreButton);
        }
    }

}