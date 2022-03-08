using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SACodeCampTest.models
{
    internal class MenuPage : WebPage
    {
        IWebElement VeganHawaiian => driver.FindElement(By.CssSelector("[name=Vegan Hawaiian]"));
        IWebElement VeganSupreme => driver.FindElement(By.CssSelector("[name=Vegan Supreme]"));
        public MenuPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal bool VeganPizzaPricesOK()
        {
            if (VeganHawaiian.FindElement(By.ClassName("price")).Text != "$14.99" 
                || VeganSupreme.FindElement(By.ClassName("price")).Text != "$14.99") return false;
            return true;
        }
    }
}
