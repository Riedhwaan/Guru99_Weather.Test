using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.UI;
using System;

namespace Weather.Test
{
    public class UnitTest1
    {
       

        [Fact]
        public void Test1()
        {
            using (var driver = new ChromeDriver("Drivers"))
            
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                driver.Url = "http://https://www.accuweather.com/en/za/cape-town/306633/weather-forecast/306633";

                string text = driver.FindElement(By.ClassName("div.temp-container")).Text;
            }
        }
    }
}