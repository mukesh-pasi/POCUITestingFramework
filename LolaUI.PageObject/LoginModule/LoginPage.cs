using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaUI.PageObject.POM.LoginModule
{
    public class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        By inputUserName = By.XPath("//input[@name='username']");
        By inputPassword = By.XPath("//input[@name='password']");
        By btnLogin = By.XPath("//button[@type='submit']");
        By lnkForgotPwd = By.XPath("//p[contains(@class,'login-forgot-header')]");
        // dynamic xpath ex
        // public IWebElement LblName( string text) => driver.FindElement(By.XPath("//button[text()='"+text+"']"));


        public IWebElement InputUserName => driver.FindElement(inputUserName);
        public IWebElement InputPassword => driver.FindElement(inputPassword);
        public IWebElement BtnLogin => driver.FindElement(btnLogin);
        public IWebElement LnkForgotPwd => driver.FindElement(lnkForgotPwd);
    }
}
