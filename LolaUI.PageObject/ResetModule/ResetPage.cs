using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaUI.PageObject.POM.ResetModule
{
    public class ResetPage:BasePage
    {
        public ResetPage(IWebDriver driver) : base(driver) { }

        By lnkBtnForgotPwd = By.XPath("//p[contains(@class,'login-forgot-header')]");
        By inputUserName = By.XPath("//input[@name='username']");
        By btnReset = By.XPath("//button[@type='submit']");
        By lblSuccessMsg = By.TagName("h6");


        public IWebElement InputUserName => driver.FindElement(inputUserName);
        public IWebElement LnkBtnForgotPwd => driver.FindElement(lnkBtnForgotPwd);
        public IWebElement BtnReset => driver.FindElement(btnReset);
        public IWebElement LblSuccessMsg => driver.FindElement(lblSuccessMsg);

    }
}









