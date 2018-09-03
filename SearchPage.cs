using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public  class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            Console.WriteLine("inside constructor search");
        }

        public SelectElement location => new SelectElement(driver.FindElement(By.Name("location")));
        
                                   
           public  SelectElement hotel => new SelectElement(driver.FindElement(By.Name("hotels")));
        

            public SelectElement room => new SelectElement(driver.FindElement(By.Name("room_type")));
        
                     
           public  SelectElement noroom => new SelectElement(driver.FindElement(By.Name("room_nos")));
        

         public   IWebElement date_in => driver.FindElement(By.Name("datepick_in"));
        public    IWebElement date_out => driver.FindElement(By.Name("datepick_out"));
        public SelectElement adult => new SelectElement(driver.FindElement(By.Name("adult_room")));
    
       
                
           public SelectElement child => new SelectElement(driver.FindElement(By.Name("child_room")));

           public  IWebElement search => driver.FindElement(By.Name("Submit"));
        public IWebElement Message => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[1]/td[1]"));
        public IWebElement Error => driver.FindElement(By.LinkText("login_title"));

        public void SearchHotel()
        {
            location.SelectByValue("Melbourne");
            hotel.SelectByValue("Hotel Hervey");
            room.SelectByValue("Double");
            noroom.SelectByText("2 - Two");

            date_in.Clear();
            date_in.SendKeys($"{DateTime.Now.AddDays(10):dd/MM/yyyy}");

            date_out.Clear();
            date_out.SendKeys($"{DateTime.Now.AddDays(15):dd/MM/yyyy}");
            adult.SelectByIndex(2);
            child.SelectByIndex(4);
            search.Click();
            Console.WriteLine("inside search");
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => driver.FindElement(By.Id("radiobutton_0")).Displayed);
                Console.Write("inside wait");
            }
            catch (Exception)
            {

                Console.Write("Catch Exception");
            }

        }
    }
}
