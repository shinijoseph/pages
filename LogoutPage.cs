using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
    public class LogoutPage
    {
        private IWebDriver driver;


       public IWebElement log_out => driver.FindElement(By.Name("logout"));

        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Logout()
        {
            log_out.Click();
           
        }
    }
}
