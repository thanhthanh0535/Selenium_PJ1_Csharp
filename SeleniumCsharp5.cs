using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Model;
namespace Selenium_PJ1_Csharp
{
    [TestFixture]
    public class SeleniumCsharp5
    {   
        
        AventStack.ExtentReports.ExtentReports extent1 = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            // var reportDir = Path.Combine(TestContext.CurrentContext.WorkDirectory, "ExtentReport");
            // Directory.CreateDirectory(reportDir);
            // var reportPath = Path.Combine(reportDir, "extent1.html");
            extent1 = new AventStack.ExtentReports.ExtentReports();
            var htmlReporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter("/Users/thanhthanh0535/Selenium_PJ1_Csharp/ExtentReport/extent1.html");
            extent1.AttachReporter(htmlReporter);
            
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {

            extent1.Flush();
        }
        [NUnit.Framework.Test]
        public void Test1()
        {
           IWebDriver driver = null;
           ExtentTest test1 = null;
            try
            {
            test1 = extent1.CreateTest("Facebook Login Test1").Info("Test Started 1");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            test1.Log(Status.Info, "Chrome Browser Launched");
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            //driver.Url = urlName;
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            test1.Log(Status.Info, "Email ID entered");
            driver.Quit();
            test1.Log(Status.Pass, "Test1 Passed");
            
            }
            catch (Exception e)
            {
                test1.Log(Status.Fail, e.ToString());
               throw; 
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
    }
}