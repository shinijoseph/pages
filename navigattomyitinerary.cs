using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public  class Navigattomyitinerary
    {

        private IWebDriver driver;
        public Navigattomyitinerary(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement my_itinerary => driver.FindElement(By.XPath("//a[@href ='BookedItinerary.php']"));
        public void NavigatetoMyitinerary()
        {
            my_itinerary.Click();
        }
   


    }
}
