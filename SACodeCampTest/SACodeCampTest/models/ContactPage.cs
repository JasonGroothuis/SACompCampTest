
using System;
using OpenQA.Selenium;

namespace SACodeCampTest.models
{
    internal class ContactPage : WebPage
    {
        public IWebElement contactBtn => driver.FindElement(By.CssSelector("[aria-label=contact]"));
        public IWebElement submitBtn => driver.FindElement(By.CssSelector("[aria-label=submit]"));

        IWebElement foreNameError => driver.FindElement(By.Id("forename-err"));
        IWebElement emailError => driver.FindElement(By.Id("email-err"));
        IWebElement messageError => driver.FindElement(By.Id("message-err"));

        IWebElement foreName => driver.FindElement(By.Id("forename"));
        IWebElement eMail => driver.FindElement(By.Id("email"));
        IWebElement message => driver.FindElement(By.Id("message"));

        public ContactPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal bool ClickSubmitRequiredShows()
        {
            submitBtn.Click();
            new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(2)).Until(d => foreNameError.Displayed);

            return foreNameError.Displayed && emailError.Displayed && messageError.Displayed;
        }

        internal bool ForenameEnteredNoError()
        {
            foreName.SendKeys("Dan");
            submitBtn.Click();
            bool retval;
            try
            {
                retval = !foreNameError.Displayed;
            }
            catch
            {
                retval = true;
            }

            return retval;
        }

        internal bool EmailEnteredNoError()
        {
            eMail.SendKeys("dan@abc.com");
            submitBtn.Click();
            bool retval;
            try
            {
                retval = !emailError.Displayed;
            }
            catch
            {
                retval = true;
            }

            return retval;
        }

        internal bool messageEnteredNoError()
        {
            message.SendKeys("Nice Pizza");
            submitBtn.Click();
            bool retval;
            try
            {
                retval = !messageError.Displayed;
            }
            catch
            {
                retval = true;
            }

            return retval;
        }
    }
}
