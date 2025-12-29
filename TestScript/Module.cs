using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenium_PJ1_Csharp.Baseclass;
using Selenium_PJ1_Csharp.PageObject;

namespace Selenium_PJ1_Csharp.TestScript
{
    [TestFixture]
    public class Module1 :BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var seachpage = new SearchPage(driver);
            //seachpage.NavigateToResult();
            var resultpage = seachpage.NavigateToResult();
            resultpage.NavigateToVideo();
            Thread.Sleep(5000);
        }
    }
}