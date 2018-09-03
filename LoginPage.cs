using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public  class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
       
     
        public IWebElement username => driver.FindElement(By.Name("username"));
       public  IWebElement password => driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));
        public IWebElement Message => driver.FindElement(By.XPath("//table[@class = 'login']//tr[1]//td[1]"));

     
 
      

        public void Login()
        {

            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Url = "http://www.adactin.com/HotelAppBuild2/";

            Browser.driver.Manage().Window.Maximize();
            username.SendKeys("shinijoseph");
            password.SendKeys("Shinijoseph");
            LoginButton.Click();
        }


        }
    }

