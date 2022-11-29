using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;



namespace LolaUI.PageObject.POM
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            this.driver.Manage().Window.Maximize();
        }
        
        public void OpenLoginPage()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            VerifyPageLoad();
        }

        public void VerifyPageLoad(double second = 20)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));

            IJavaScriptExecutor? js = driver as IJavaScriptExecutor;
            string pageLoadstatus = (string)js.ExecuteScript("return document.readyState");

            wait.Until(p => pageLoadstatus == "complete");
            Thread.Sleep(3000);
        }

        public void ClickedOnElement(IWebElement element)
        {
            element.Click();
        }
        public void ClickedOnElement(IWebElement element, By locator, double second = 15)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

            element.Click();
        }
        public void SendKeys11(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
        public void WaitforElementToBeDisplay(By id, double second = 5)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(id));
            }
            catch (Exception)
            {


            }
        }

        public bool IsTextBoxTextDisplayed(IWebElement element, string text)
        {
            return element.Displayed && element.GetAttribute("value") == text;
        }

        
    }
}
