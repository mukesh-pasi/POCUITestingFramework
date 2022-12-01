using OpenQA.Selenium;

namespace LolaUI.PageObject.POM.HomeModule
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        public bool IsHomePage()
        {
            VerifyPageLoad();
            return driver.Url.EndsWith("/dashboard/index");

        }

    }
}
