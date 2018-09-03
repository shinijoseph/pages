using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public  class BookingPage
    {
        private IWebDriver driver;
        public BookingPage(IWebDriver driver)
        {
            this.driver = driver;
            Console.WriteLine("inside constructor booking");
        }

       public string order_id;
        public IWebElement firstname => driver.FindElement(By.Name("first_name"));
        public IWebElement lastname => driver.FindElement(By.Name("last_name"));
        public IWebElement addr => driver.FindElement(By.Name("address"));
        public IWebElement card => driver.FindElement(By.Name("cc_num"));
        public IWebElement cvv => driver.FindElement(By.Name("cc_cvv"));
        public IWebElement book => driver.FindElement(By.Name("book_now"));



         
        public SelectElement cardtype => new SelectElement(driver.FindElement(By.Name("cc_type")));
               
       public SelectElement exmonth => new SelectElement(driver.FindElement(By.Name("cc_exp_month")));
     
       public SelectElement exyear => new SelectElement(driver.FindElement(By.Name("cc_exp_year")));
        public IWebElement Message => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[1]/td[1]"));
        public IWebElement Error => driver.FindElement(By.LinkText("login_title"));
        public IWebElement orderid => driver.FindElement(By.XPath("//table[contains(@class, 'login')]/tbody/tr[18]/td/input"));
        public void BookingHotel()
        {
            firstname.SendKeys("Shini");
            lastname.SendKeys("Joseph");
            addr.SendKeys(" 883,  Docklands,   Melbourne,  Victoria,    Australia");
            card.SendKeys("818181212121313131515151");
            cardtype.SelectByIndex(2);
            exmonth.SelectByIndex(9);
            exyear.SelectByIndex(9);
            cvv.SendKeys("222");
            book.Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => driver.FindElement(By.Id("search_hotel")).Displayed);
                Console.Write("inside wait");
            }
            catch (Exception)
            {

                Console.Write("Catch Exception");
            }

            order_id = orderid.GetAttribute("value");

        }        

    }
}
