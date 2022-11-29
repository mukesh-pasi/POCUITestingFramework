using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecflowPOC.Hooks
{
    [Binding]
    public class ScreenShotHooks
    {
        //    private readonly IObjectContainer container;
        //    FeatureContext featureContext;
        //    ScenarioContext scenarioContext;
        //    public ScreenShotHooks(IObjectContainer container, FeatureContext featureContext, ScenarioContext scenarioContext)
        //    {
        //        this.container = container;
        //        this.featureContext = featureContext;
        //        this.scenarioContext = scenarioContext;
        //    }

        //[AfterScenario(Order = 1)]
        //public void ScreenShotWebdriver()
        //{
        //    var driver = container.Resolve<IWebDriver>();
        //    if (scenarioContext.TestError !=null)
        //    {
        //        TakeScreenshot(driver);
        //    }
        //}

        //void TakeScreenshot(IWebDriver driver)
        //{
        //    try
        //    {
        //        string fileName = string.Format("Error_{0}_{1}_{2}",
        //                featureContext.FeatureInfo.Title,
        //                scenarioContext.ScenarioInfo.Title,
        //                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png");
        //        var artifactoryDirectory = Path.Combine(Directory.GetCurrentDirectory(), "Screenshot");
        //        if (!Directory.Exists(artifactoryDirectory))
        //            Directory.CreateDirectory(artifactoryDirectory);
        //        ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
        //        if (takesScreenshot != null)
        //        {
        //            var screenshot = takesScreenshot.GetScreenshot();
        //            string screenshotFilePath = Path.Combine(artifactoryDirectory, fileName);
        //            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
        //            Console.WriteLine("<a href='{0}' target='_blank'>Screenshot</a>", new Uri(screenshotFilePath));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error while taking screenshot: {0}", ex);
        //        // log error capture

        //    }
        //}
    }
    
}
