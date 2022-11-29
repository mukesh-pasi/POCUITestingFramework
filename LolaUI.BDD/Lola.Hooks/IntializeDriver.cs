using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowPOC.Hooks
{
    [SetUpFixture]
    public class WebDriverHooks
    {
        readonly IObjectContainer container;
        public WebDriverHooks(IObjectContainer container)
        {
            this.container = container;
        }

        [SetUp]
        public void CreateWebdriver()
        {
            ChromeDriver driver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [TearDown]
        public void DestroyWebdriver()
        {
            ChromeDriver driver = new ChromeDriver();

           // var driver = container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Close();
                driver.Quit();

            }
        }
    }

}
