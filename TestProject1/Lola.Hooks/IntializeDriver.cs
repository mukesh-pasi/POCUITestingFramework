using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecflowPOC.Hooks
{
    [Binding]
    public class WebDriverHooks
    {
        readonly IObjectContainer container;
        public WebDriverHooks(IObjectContainer container)
        {
            this.container = container;
        }
        [BeforeScenario]

        public void CreateWebdriver()
        {
            ChromeDriver driver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void DestroyWebdriver()
        {
            var driver = container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Close();
                driver.Quit();

            }
        }

    }
}
