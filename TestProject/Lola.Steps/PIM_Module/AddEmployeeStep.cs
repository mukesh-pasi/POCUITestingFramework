using LolaUI.PageObject.PIM_Module;
using LolaUI.PageObject.POM.HomeModule;
using LolaUI.PageObject.POM.LoginModule;
using LolaUI.PageObject.POM.ResetModule;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace TestProject
{
    [Binding]
    public class AddEmployeeStep
    {
        AddEmployeePage addEmployeePage;
        LoginPage loginPage;
        HomePage homePage;
        ScenarioContext scnearioContext;

        public AddEmployeeStep(IWebDriver driver, ScenarioContext scnearioContext)
        {
            this.scnearioContext = scnearioContext;
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            addEmployeePage = new AddEmployeePage(driver);
        }


        [Given(@"User on home page")]
        public void GivenUserOnHomePage()
        {
            loginPage.OpenLoginPage();
            loginPage.InputUserName.SendKeys("Admin");
            loginPage.InputPassword.SendKeys("admin123");
            loginPage.BtnLogin.Click();
        }

        [When(@"user clicked on PIM module")]
        public void WhenUserClickedOnPIMModule()
        {
            addEmployeePage.PIM.Click();
            Thread.Sleep(3000);
        }

        [When(@"user clicked on Add Employee Tab")]
        public void WhenUserClickedOnAddEmployeeTab()
        {
            addEmployeePage.AddEmployee.Click();
            Thread.Sleep(3000);
        }

        [When(@"user adding the FirstName as ""([^""]*)""")]
        public void WhenUserAddingTheFirstNameAs(string firstName)
        {
            addEmployeePage.FirstName.SendKeys(firstName);  
        }

        [When(@"user adding the MiddleName as ""([^""]*)""")]
        public void WhenUserAddingTheMiddleNameAs(string middleName)
        {
            addEmployeePage.MiddleName.SendKeys(middleName);    
        }

        [When(@"user adding the LastName as ""([^""]*)""")]
        public void WhenUserAddingTheLastNameAs(string lastName)
        {
            addEmployeePage.LastName.SendKeys(lastName);    
        }

        [When(@"user adding the EmployeeId as ""([^""]*)""")]
        public void WhenUserAddingTheEmployeeIdAs(string employeeId)
        {
            addEmployeePage.EmployeeId.SendKeys(employeeId);
        }

        [When(@"user clicked on save button")]
        public void WhenUserClickedOnSaveButton()
        {
            addEmployeePage.SaveBtn.Click();
        }


        [Then(@"success message displayed")]
        public void ThenSuccessMessageDisplayed()
        {
            Assert.IsTrue(addEmployeePage.Valid_sms.Text.Contains("Successfully Saved"), "Successfully Saved");
        }


        
    }
}
