using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace EshProject
{
    public abstract class BaseEsh
    {
        private IWebDriver driver;
        public IWebDriver Driver => driver;

        public const string Url = "https://web.eos.bnk-il.com/auth";


        protected ReportResult reportResult;

        public BaseEsh()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.FullScreen();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            reportResult = new ReportResult();
        }

        public void InsertUrl(string Url)
        {
            driver.Url = Url;
        }
    }
}
