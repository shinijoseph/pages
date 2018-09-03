using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
   public class CancellationPage
    {
        private IWebDriver driver;
        public CancellationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
       // string path = "//input[(@type="submit")]"
        public IWebElement selectall => driver.FindElement(By.XPath("//table[contains (@class, 'login')]/tbody/tr[2]/td/table/tbody/tr[1]/td/div/input"));
        public IWebElement cancelall => driver.FindElement(By.XPath("//table[contains (@class, 'login')]/tbody/tr[3]/td/input"));

      /*  public void CancelAll()
        {
            selectall.Click();
            cancelall.Click();
            IAlert alert = Browser.driver.SwitchTo().Alert();
            alert.Accept();
        }*/

        public IWebElement data;
        public IWebElement data_act;
        public void CancellSpecific(string value)
        {


            int i, j;
            int row, col;
            string row_xpath = "//table[contains (@class, 'login')]/tbody/tr[2]/td/table/tbody/tr";
            string col_xpath = "//table[contains (@class, 'login')]/tbody/tr[2]/td/table/tbody/tr[1]/td";
            row = driver.FindElements(By.XPath(row_xpath)).Count;
            col = driver.FindElements(By.XPath(col_xpath)).Count;
            Console.WriteLine("Row" + row);
            Console.WriteLine("Column" + col);

            for (i = 2; i <= row; i++)
            {
                Console.WriteLine("\n");
                for (j = 2; j <= col; j++)
                {

                    data = driver.FindElement(By.XPath(row_xpath + "[" + i + "]/td[" + j + "]/input"));
                    int k = j - 1;
                    Console.WriteLine(k);
                   
                    data_act = driver.FindElement(By.XPath(row_xpath + "[" + i + "]/td[" + k + "]/input"));
                    string val = data.GetAttribute("value");
                    Console.WriteLine(val);

                    if (val.Equals(value))
                    {
                        data_act.Click();
                        cancelall.Click();
                        IAlert alert = Browser.driver.SwitchTo().Alert();
                        alert.Accept();
                        break;
                       
                    }
                    else
                    {
                        Console.WriteLine("Else checking");
                        
                    }
                }
            }


        }
    }
}
