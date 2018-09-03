using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public  class ScenarioLogin
    {
        private IWebDriver driver;

        public IWebElement username => driver.FindElement(By.Name("username"));
        public IWebElement password => driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));
        public IWebElement Message => driver.FindElement(By.XPath("//table[contains(@class, 'content')]/tbody/tr[1]/td[1]"));
        public IWebElement Error => driver.FindElement(By.TagName("b"));

    


    }
}
