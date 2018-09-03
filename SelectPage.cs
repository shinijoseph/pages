using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
    public class SelectPage
    {
        private IWebDriver driver;

        public SelectPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement select => driver.FindElement(By.Name("radiobutton_0"));
        public IWebElement cont => driver.FindElement(By.Name("continue"));
        public IWebElement Message => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[2]/td[1]"));
        public IWebElement Error => driver.FindElement(By.LinkText("login_title"));
        

        public void SelectHotel()
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => driver.FindElement(By.Id("radiobutton_0")));
                Console.Write("finding radiobutton");
            }
            catch (Exception)
            {

                Console.Write("Catch Exception");
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
               
        select.Click();
           cont.Click();
        }

    }
   }
