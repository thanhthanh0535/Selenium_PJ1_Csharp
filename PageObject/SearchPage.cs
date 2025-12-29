using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V141.WebAuthn;

namespace Selenium_PJ1_Csharp.PageObject
{
    public class SearchPage
    {   
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Name, Using = "search_query")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[aria-label='Search']")]
        public IWebElement SearchButton { get; set; }
        public ResultPage NavigateToResult()
        {
            SearchBox.SendKeys("Selenium C# Full Course by Bakkappa N");
            SearchButton.Click();
            return new ResultPage(driver);
        }  
    }
}