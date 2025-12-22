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

namespace Selenium_PJ1_Csharp.TestClass
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Url = "https://www.facebook.com";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            IWebElement monthDropdownlist = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownlist);
            element.SelectByIndex(1); //Select by index
            element.SelectByText("Feb"); //Select by text
            element.SelectByValue("2"); //Select by value
            Thread.Sleep(5000);
            //driver.Quit();
        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Thread.Sleep(5000);
        }


    }
}


