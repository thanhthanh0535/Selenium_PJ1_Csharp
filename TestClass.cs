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
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Url = "https://www.facebook.com";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@id='u_0_h_ah']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropdownlist = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownlist);
            element.SelectByIndex(1); //Select by index
            element.SelectByText("Feb"); //Select by text
            element.SelectByValue("4"); //Select by value
            //driver.Quit();
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }


    }
}


