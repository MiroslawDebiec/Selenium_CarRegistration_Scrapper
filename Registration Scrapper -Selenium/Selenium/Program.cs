//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {

            //var options = new ChromeOptions();
            //options.AddArgument("--disable-gpu");
            //var driver = new ChromeDriver(options);
            var driver = new PhantomJSDriver();
            var car = new Car();
            bool isEnd = false;
           

            while (isEnd == false)
            {
                try
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("ENETR VALID UK CAR REGISTRATION: ");
                    car.Registration = Console.ReadLine();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    driver.Url = "https://vehicleenquiry.service.gov.uk/";

                    driver.FindElementById("Vrm").SendKeys(car.Registration);
                    driver.FindElementByClassName("button").Click();
                    driver.FindElementByXPath("//*[@id=\"Correct_True\"]").Click();
                    driver.FindElementByClassName("button").Click();
                    car.Make = (driver.FindElementByXPath("//*[@id=\"content\"]/div[4]/div/ul/li[1]/span[2]/strong")).Text;
                    car.Color = (driver.FindElementByXPath("//*[@id=\"content\"]/div[4]/div/ul/li[10]/span[2]/strong")).Text;
                    car.Year = (driver.FindElementByXPath("//*[@id=\"content\"]/div[4]/div/ul/li[3]/span[2]/strong")).Text;
                    car.Tax = (driver.FindElementByXPath("//*[@id=\"content\"]/div[2]/div[1]/div[1]/p/strong")).Text; 
                    car.Mot = (driver.FindElementByXPath("//*[@id=\"content\"]/div[2]/div[2]/div[1]/p/strong")).Text;

                    Console.WriteLine("-------------Modified---------------");
                    Console.WriteLine("-------------Modified--InGitKraken-------------");
                    Console.WriteLine(" * REGISTRATION: {0}\n * MAKE: {1}\n * COLOR: {2}\n * YEAR: {3}\n * TAX: {4}\n * MOT: {5}", car.Registration, car.Make, car.Color, car.Year, car.Tax, car.Mot);
                }
                catch (Exception)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("      !!! INVALID REGISTRATION ENTERED !!!");
                }
            }
            driver.Close();
        }
    }
}
