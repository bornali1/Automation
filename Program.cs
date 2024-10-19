using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Firstselenium
{
    static void Main(string[] args)
    {


        IWebDriver driver = new ChromeDriver();
        ExtentReports extentReports = new ExtentReports();

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        Console.WriteLine("Open Browser");
        
        driver.Manage().Window.Maximize();

        driver.FindElement(By.Id("username")).SendKeys("student");
        Console.WriteLine("Provide username");

        driver.FindElement(By.Id("password")).SendKeys("Password1234tfh");
        Console.WriteLine("Provide Password");

        driver.FindElement(By.Id("submit")).Click();
        Console.WriteLine("Hit submit button");

        driver.FindElement(By.CssSelector("#loop-container > div > article > div.post-content > div > div > div > a")).Click();
        Console.WriteLine("Failed Login");
    }
    

    

}