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
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace Selenium_PJ1_Csharp.TestClass
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            driver.Close();
        }

        [Test, Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            driver.Close();
        }
        [Test, Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new SafariDriver();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            driver.Close();
        }


    }
}


