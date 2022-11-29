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
        // to do config file- check local /db data en and write sql command query(ado.net)- to fetch test data from db
        //FeatureContext featureContext;
       // ScenarioContext scenarioContext;
        // model class GET Set operation
        //config file keys will be env, local,db(true/false), so we will pass constructor parameter of env and types of data(local/db)
        [BeforeScenario]
        public void GetLocalData()
        {
            //to do
            // to do add test data(key, value) in context-hooks module
            // fetch test data in step defintion by context.TryGetValue(key)
            //this.scenarioContext = scenarioContext;


        }
        public void ParseJsonFile(string file)
        {

        }
    }
}
