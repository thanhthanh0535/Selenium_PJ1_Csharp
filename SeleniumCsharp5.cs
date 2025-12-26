using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Script;
using OpenQA.Selenium.Chrome;

namespace Selenium_PJ1_Csharp
{
    [TestFixture]
    public class SeleniumCsharp5
    {
        [Test]
        public void Test1()
        {
           IWebDriver driver = null;
            try
            {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/r.php?entry_point=login";
            //driver.Url = urlName;
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            driver.Quit();
            }
            catch
            {
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