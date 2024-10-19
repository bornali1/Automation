using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Firstselenium
{
    static void Main(string[] args)
    {


        IWebDriver driver = new ChromeDriver();
        ExtentReports extentReports = new ExtentReports();
        ExtentSparkReporter reportpath = new ExtentSparkReporter(@"C:\ReportLocation\report.Now.ToString("_MMddyy_hgv").+html);
        extentReports.AttachReporter(reportpath);
        ExtentTest test = extentReports.CreateTest("Login test", "This is our first test case");

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
        test.Log(Status.Info, "Open browser");
        Console.WriteLine("Open Browser");
        
        driver.Manage().Window.Maximize();

        driver.FindElement(By.Id("username")).SendKeys("student");
        test.Log(Status.Info, "Provide username");
        Console.WriteLine("Provide username");

        driver.FindElement(By.Id("password")).SendKeys("Password1234tfh");
        test.Log(Status.Info, " Provide Password");
        Console.WriteLine("Provide Password");

        driver.FindElement(By.Id("submit")).Click();
        test.Log(Status.Info, "Hit submit button");
        Console.WriteLine("Hit submit button");
        try
        {
            driver.FindElement(By.CssSelector("#loop-container > div > article > div.post-content > div > div > div > a")).Click();
        }
        catch
        {
            Console.WriteLine("Failed Login");
        }
        driver.Quit();
        extentReports.Flush();
    }

    static void main ()

        private static void CreateReportDirectories()
    {
        string ReportPath = @"C:\ReportLocation\";
        if (Directory.Exists(ReportPath))
        {
            Directory.CreateDirectory(ReportPath);
        }
    }
    

    

}