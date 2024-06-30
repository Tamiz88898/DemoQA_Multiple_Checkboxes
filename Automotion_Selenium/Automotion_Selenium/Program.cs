using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace Automotion_Selenium
{
    internal class Program
    {
        public static IWebDriver driver;
        public static IWebElement document;

        static void Main(string[] args)
        {
            driver = new FirefoxDriver();
            driver.Url = "https://demoqa.com/checkbox";

           // var document = driver.FindElement(By.TagName("body"));


           // document.SendKeys(Keys.Down);
           // document.SendKeys(Keys.Down);
           // ExpandElement("Home");


           //ExpandElement("Downloads");


           // SelectElement("Word File.doc");
           // SelectElement("Excel File.doc");


            string[] ExpandElements = { "Home", "Desktop", "Documents", "Downloads", "WorkSpace", "Office" };
            string[] SelectElements = { "Notes", "Commands", "Angular","Private","Word File.doc","Excel File.doc" };


            for (int i = 0; i < ExpandElements.Length; i++)
            {
                ExpandElement(ExpandElements[i]);
            }

            for (int i = 0; i < SelectElements.Length; i++)
            {
                SelectElement(SelectElements[i]);
            }

            //driver.Close();
        }



        public static void ExpandElement(string ExpandElements)
        {
           // document.SendKeys(Keys.Down);
            //document.SendKeys(Keys.Down);
            var homeCheckbox = driver.FindElement(By.XPath($"//span[@class='rct-title' and text()='{ExpandElements}']/ancestor::span/button"));
            homeCheckbox.Click();
     
        }

        public static void SelectElement(string SelectElements)
        {
            var chekBox = driver.FindElement(By.XPath($"//span[@class='rct-title' and text()='{SelectElements}']"));
            chekBox.Click();
        }

    }


}
