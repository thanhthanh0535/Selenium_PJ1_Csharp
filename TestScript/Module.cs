using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
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
            //resultpage.NavigateToVideo();
            var Channelpage = resultpage.NavigateToChannel();
            string actualChannelName = Channelpage.getChannelName();
            // Console.WriteLine("Actual Channel Name: " + actualChannelName);
            // string expectedChannelName1 = "BangersOnly";
            // //Console.WriteLine("Expected Channel Name: " + expectedChannelName1);
            // Assert.That(expectedChannelName1, Is.EqualTo(actualChannelName).IgnoreCase);
            Thread.Sleep(3000);
        }
    }
}