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

namespace Selenium_PJ1_Csharp.ParallelTesting
{
    [TestFixture]
    public class Parallel_Testing : BaseTest
    {
        IWebDriver driver;
        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField= Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            Driver.Close();
        }
    }
}


