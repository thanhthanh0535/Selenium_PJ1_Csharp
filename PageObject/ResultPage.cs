using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.DevTools.V141.WebAuthn;

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
        //[FindsBy(How = How.LinkText, Using = "button[aria-label='Selenium C# Full Course by Bakkappa N']")]
        [FindsBy(How = How.PartialLinkText, Using = "Selenium C# Full Course by Bakkappa N")]
        public IWebElement ResultLinkText { get; set; }        
        public void NavigateToVideo()
        {
            Thread.Sleep(5000);
            ResultLinkText.Click();
            //return new ResultPage(driver);
        }
    }
}