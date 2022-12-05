using LolaUI.PageObject.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolaUI.PageObject.PIM_Module
{
    public class SearchEmployeePage:BasePage
    {
        public SearchEmployeePage(IWebDriver driver) : base(driver) { }

        By employeeList = By.XPath("//li[@class='oxd-topbar-body-nav-tab --visited']");
        By employeeName = By.XPath("(//input[@placeholder='Type for hints...'])[1]");
        By searchBtn = By.XPath("(//button[normalize-space()='Search'])[1]");
        By valid_Name = By.XPath("//div[contains(text(),'Harry John')]");

        public IWebElement EmployeeList => driver.FindElement(employeeList);
        public IWebElement EmployeeName => driver.FindElement(employeeName);
        public IWebElement SearchBtn => driver.FindElement(searchBtn);
        public IWebElement Valid_Name => driver.FindElement(valid_Name);





    }
}
