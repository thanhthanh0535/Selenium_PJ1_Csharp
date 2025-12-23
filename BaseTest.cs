using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Selenium_PJ1_Csharp.Baseclass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
