using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
    class BookedItineraryPage
    {
        private IWebDriver driver;

        public BookedItineraryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
           
       public IWebElement Table => driver.FindElement(By.XPath("//table[contains (@class, 'login')]"));

       public IWebElement data;
        public void BookedItinerary()
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
                for (j = 1; j <= col; j++)
                {
                    data = driver.FindElement(By.XPath(row_xpath + "[" + i + "]/td[" + j + "]/input"));
                    Console.Write(data.GetAttribute("value"));
                    Console.Write("\t");
                }
            }

            /******************************* ASSG2************************************************************/



            /*  string before_xpath = "//table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[";
               //string after_xpath = "]/input";

              row = driver.FindElements(By.XPath("//table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr")).Count;
              col = driver.FindElements(By.XPath("//table[2]/tbody/tr[2]/td/form/table/tbody/tr[2]/td/table/tbody/tr[1]/td")).Count;
              Console.WriteLine("Row" + row);
              Console.WriteLine("Column" + col);

              for (i=2;i<=row;i++)
               {
                   for (j=2;j<=col;j++)
                   {
                       det = driver.FindElement(By.XPath(before_xpath + i + "]/*[" + j + "]/input"));
                       Console.WriteLine(det.GetAttribute("value"));
                   }
               }*/

            /*------------------------ASSG1-----------------------------------------------------------------  */
            //  IList<IWebElement> elements = driver.FindElements(By.XPath("//input[starts-with(@name, 'order_id')]"));
            //  string[] orderid = new string[elements.Count];
            //int i = 0;


            /*        foreach (IWebElement element in elements)
                    {
                        /*  orderid[i]  = element.GetAttribute("value");
                         Console.WriteLine(" Order ID::: " + orderid[i]);

                         i++;*/
            /*   Console.WriteLine(element.GetAttribute("value"));

               }*/
        }

        }
    }