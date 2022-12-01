using LolaUI.PageObject.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LolaUI.PageObject.PIM_Module
{
    public class AddEmployeePage: BasePage
    {
        public AddEmployeePage(IWebDriver driver) : base(driver) { }
       

        By pim= By.XPath("//span[text()='PIM']");
        By addEmployee = By.XPath("//header[@class='oxd-topbar']//li[3]");
        By firstName = By.XPath("//input[@placeholder='First Name']");
        By middleName = By.XPath("//input[@placeholder='Middle Name']");
        By lastName = By.XPath("//input[@placeholder='Last Name']");
        By employeeId = By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");
        By saveBtn = By.XPath("//button[normalize-space()='Save']");
        By personaldetailesPage = By.XPath("(//h6[normalize-space()='Personal Details'])[1]");
        By valid_sms = By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text']");

        public IWebElement PIM => driver.FindElement(pim);

        public IWebElement AddEmployee => driver.FindElement(addEmployee);
        public IWebElement FirstName => driver.FindElement(firstName);
        public IWebElement MiddleName => driver.FindElement(middleName);
        public IWebElement LastName => driver.FindElement(lastName);
        public IWebElement EmployeeId => driver.FindElement(employeeId);
        public IWebElement SaveBtn => driver.FindElement(saveBtn);
        public IWebElement Personaldetailes => driver.FindElement(personaldetailesPage);
        public IWebElement Valid_sms => driver.FindElement(valid_sms);






    }
}
