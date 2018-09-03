using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel.Pages
{
public class Browser
    {
        public static IWebDriver driver = new ChromeDriver();
    }

}
