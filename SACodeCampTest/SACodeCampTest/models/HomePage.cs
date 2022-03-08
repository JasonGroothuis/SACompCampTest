using System;
using OpenQA.Selenium;

namespace SACodeCampTest.models
{

	internal class HomePage : WebPage
    {
		public IWebElement contactBtn => driver.FindElement(By.CssSelector("[aria-label=contact]"));
		public IWebElement menuBtn => driver.FindElement(By.CssSelector("[aria-label=menu]"));
		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public HomePage(IWebDriver driver, string url)
		{
			this.driver = driver;
			this.driver.Url = url;
		}

        internal void ClickContact()
        {
			contactBtn.Click();
        }

        internal void ClickMenu()
        {
			menuBtn.Click();
		}
    }
}
