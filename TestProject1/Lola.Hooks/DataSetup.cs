using OpenQA.Selenium.DevTools.V105.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace TestProject1.Lola.Hooks
{
    [Binding]
    public class DataSetup
    {
       
        [BeforeScenario]
        public void GetLocalData()
        {
            
        }
        
    }
}
