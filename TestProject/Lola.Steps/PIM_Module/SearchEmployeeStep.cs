using LolaUI.PageObject.PIM_Module;
using LolaUI.PageObject.POM.HomeModule;
using LolaUI.PageObject.POM.LoginModule;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace TestProject.Lola.Steps.PIM_Module
{
    [Binding]
    public class SearchEmployeeStep
    {
        SearchEmployeePage searchEmployeePage;
        AddEmployeePage addEmployeePage;
        LoginPage loginPage;
        HomePage homePage;
        ScenarioContext scnearioContext;

        public SearchEmployeeStep(IWebDriver driver, ScenarioContext scnearioContext)
        {
            this.scnearioContext = scnearioContext;
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            addEmployeePage = new AddEmployeePage(driver);
            searchEmployeePage = new SearchEmployeePage(driver);
        }


        [Given(@"user on Homepage")]
        public void GivenUserOnHomepage()
        {
            loginPage.OpenLoginPage();
            loginPage.InputUserName.SendKeys("Admin");
            loginPage.InputPassword.SendKeys("admin123");
            loginPage.BtnLogin.Click();
        }

        [When(@"user click on PIM module")]
        public void WhenUserClickOnPIMModule()
        {
            addEmployeePage.PIM.Click();
            Thread.Sleep(3000);
        }

        [When(@"user Click on Employee List")]
        public void WhenUserClickOnEmployeeList()
        {
            addEmployeePage.PIM.Click();
            Thread.Sleep(3000);
        }

        [When(@"user insert in Employee name as ""([^""]*)""")]
        public void WhenUserInsertInEmployeeNameAs(string Harry)
        {
            searchEmployeePage.EmployeeName.SendKeys("Harry");
            
        }

        [When(@"user click on Search Button")]
        public void WhenUserClickOnSearchButton()
        {
            searchEmployeePage.SearchBtn.Click();
        }

        [Then(@"user see EmployeeName in table")]
        public void ThenUserSeeEmployeeNameInTable()
        {
            Assert.IsTrue(searchEmployeePage.Valid_Name.Text.Contains("Harry John"),"Harry John");
            // Assert.IsTrue(addEmployeePage.Valid_sms.Text.Contains("Successfully Saved"), "Successfully Saved");
        }
    }
}
