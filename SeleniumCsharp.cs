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
    public class SeleniumCsharp4
    {
        [Test]
        [Author("Tran Thanh Than Nguyen", "thanhthanh0535@gmail.com")]
        [Description("Facebok login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = urlName;
            IWebElement emailTextField= driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("thanhthanh0535@gmail.com");
            driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }
            }
        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/r.php?entry_point=login");
            list.Add("https://www.youtube.com");
            list.Add("https://www.gmail.com");
            return list;
        }
        // [Test]
        // [Author("Tran Thanh Than Nguyen", "thanhthanh0535@gmail.com")]
        // [Description("Facebok login verify")]
        // public void Test2()
        // {
        //     IWebDriver driver = new ChromeDriver();
        //     driver.Manage().Window.Maximize();
        //     driver.Url = "https://www.facebook.com/r.php?entry_point=login";
        //     IWebElement emailTextField= driver.FindElement(By.XPath(".*[@name='reg_email__']"));
        //     emailTextField.SendKeys("thanhthanh0535@gmail.com");
        //     driver.Close();
        // }
    }
}