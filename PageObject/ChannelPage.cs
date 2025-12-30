using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace Selenium_PJ1_Csharp.PageObject
{
    public class ChannelPage
    {
        IWebDriver driver;
         public ChannelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#channel-title")]
        public IWebElement ChannelNamepage { get; set; }
        public String getChannelName()
        {
            Thread.Sleep(3000);
            string ChannelElement = ChannelNamepage.Text;
            return ChannelElement?.Trim();
        }
    }
}