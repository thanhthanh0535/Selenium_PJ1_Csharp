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
using LambdaToXpath;
using Selenium.Extensions;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Selenium_PJ1_Csharp
{
    [TestFixture]
    public class BrowserUtility
    {
        [Test]
        public IWebDriver Init (IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            return driver;
        }
    }
}


