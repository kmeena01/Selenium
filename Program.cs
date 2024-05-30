
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Launch Chrome Browser //
            IWebDriver driver = new ChromeDriver();
            // step 2 - Navigate to Turnup portal //
            // step 3 - Enter username value in username field //
            // step 4 - Enter password value in password field //
            // step 5 - Click Login Button //
            // step 6 - Verify user login was successfull //
        }
    }
}
