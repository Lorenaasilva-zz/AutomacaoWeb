
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DesafioShift.PageObject
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By BySignIn;
        private By ByLogin;
        private By ByPassword;
        private By BySubmitLogin;
        private By ByHome;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            BySignIn = By.XPath("//a[@class='login']");
            ByLogin = By.XPath("//*[@id='email']");
            ByPassword = By.XPath("//*[@id='passwd']");
            BySubmitLogin = By.XPath("//*[@id='SubmitLogin']");
            ByHome = By.XPath("//img[@class='logo img-responsive']");

        }

           
        public void AbrirPagina()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        public void SignIn()
        {
            driver.FindElement(BySignIn).Click();
        }

        public void PreencheDadosLogin()
        {
            string email = ("desafio.shift@gmail.com");
            string senha = ("automacao01");
            driver.FindElement(ByLogin).SendKeys(email);
            driver.FindElement(ByPassword).SendKeys(senha);
        }

        public void SubmeterLogin()
        {
            driver.FindElement(BySubmitLogin).Click();
        }

        public void BackHome()
        {
            driver.FindElement(ByHome).Click();
        }

    }
}

