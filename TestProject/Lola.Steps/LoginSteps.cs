using LolaUI.PageObject.POM.HomeModule;
using LolaUI.PageObject.POM.LoginModule;
using LolaUI.PageObject.POM.ResetModule;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace LolaUI.BDD.Lola.Steps
{
    [Binding]
    public class LoginSteps
    {
     
            LoginPage loginPage;
            ResetPage resetPage;
            HomePage homePage;
            ScenarioContext scnearioContext;
            public LoginSteps(IWebDriver driver,ScenarioContext scnearioContext)
            {
                this.scnearioContext = scnearioContext;
                loginPage = new LoginPage(driver);
                homePage = new HomePage(driver);
                resetPage = new ResetPage(driver);
            }

            [Given(@"User launched the Page")]
            public void GivenUserLaunchedThePage()
            {
                //loginPage.VerifyPageLoad(120);
                loginPage.OpenLoginPage();
            }


            [When(@"User enters the correct username as (.*) and correct password as (.*)")]
            public void WhenUserEntersTheCorrectUsernameAndPassword(string userName, string password)
            {
                loginPage.InputUserName.SendKeys(userName);
                loginPage.InputPassword.SendKeys(password);
            }


            [When(@"User clicks on the login button")]
            public void WhenUserClicksOnTheLoginButton()
            {
                loginPage.BtnLogin.Click();
            }

            [Then(@"User navigates to homepage")]
            public void ThenUserNavigatesToHomePage()
            {
                Assert.IsTrue(homePage.IsHomePage(), "User has not navigated to HomePage");
            }


            [When(@"User clicks on the forgot password link button")]
            public void WhenUserClicksOnTheForgotPasswordLinkButton()
            {
                loginPage.ClickedOnElement(loginPage.LnkForgotPwd);
                //resetPage.ClickedOnElement(resetPage.BtnReset);
                //resetPage.BtnReset();
            }

            [When(@"User navigate to reset password page")]
            public void WhenUserNavigateToResetPasswordPage()
            {
                // no action
            }

            [When(@"User enters the username as (.*)")]
            public void WhenUserEntersTheUsernameAsUsername(string p0)
            {
                resetPage.SendText(resetPage.InputUserName, p0);
            }

            [When(@"User clicks on the reset password button")]
            public void WhenUserClicksOnTheResetPasswordButton()
            {
                resetPage.ClickedOnElement(resetPage.BtnReset);
            }

            [Then(@"User sucessfully reset the password")]
            public void ThenUserSucessfullyResetThePassword()
            {
                Assert.IsTrue(resetPage.LblSuccessMsg.Text.Contains("link sent successfully"), "User has not reseted password");
            }


        }

    }

