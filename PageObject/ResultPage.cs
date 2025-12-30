using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.DevTools.V141.WebAuthn;
using System.Security.Cryptography.X509Certificates;

namespace Selenium_PJ1_Csharp.PageObject
{ 
    public class ResultPage
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
        this.driver = driver;
        PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "BangersOnly")]
        public IWebElement ChannelNameLinkText { get; set; }

        // [FindsBy(How = How.PartialLinkText, Using = "Mythborne - The Iron In Her Heart (Lyrics)")]
        // public IWebElement ResultLinkText { get; set; }        
        // public void NavigateToVideo()
        // {
        //     Thread.Sleep(5000);
        //     ResultLinkText.Click();
        //     //return new ResultPage(driver);
        // }
        public ChannelPage NavigateToChannel()
        {
            Thread.Sleep(3000);
            ChannelNameLinkText.Click();
            return new ChannelPage(driver);
        }
    }
}