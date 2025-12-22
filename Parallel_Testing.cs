using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;
using Selenium_PJ1_Csharp.Baseclass;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Selenium_PJ1_Csharp
{
    [TestFixture]
    public class Parallel_Testing : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Url = "https://www.facebook.com";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@id='u_0_h_ah']"));
            emailTextField.SendKeys("Selenium C#");
            //driver.Quit();
        }
    }
}


