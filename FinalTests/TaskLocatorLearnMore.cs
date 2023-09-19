using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace CSharpBasics.FinalTest
{
    [TestFixture]
    public class LearnMoreButtonTest
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
        public void ClickLearnMoreButtonOne()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/our-work/software-and-hi-tech");
            Thread.Sleep(1000);

            IWebElement learnMoreButton = driver.FindElement(By.XPath("//a[@href='https://solutionshub.epam.com/search?category_industries=software_hitech']"));

            Assert.IsNotNull(learnMoreButton);

            learnMoreButton.Click();

        }

        [Test]
        public void ClickLearnMoreButtonTwo()
        {
            driver.Navigate().GoToUrl("https://www.epam.com/our-work/software-and-hi-tech");
            Thread.Sleep(1000);

            IWebElement learnMoreButton = driver.FindElement(By.XPath("//a[contains(@href, 'category_industries=software_hitech')]"));

            Assert.IsNotNull(learnMoreButton);

            learnMoreButton.Click();

        }
    }

}