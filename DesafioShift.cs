using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace TesteShifth
{
    public class ComprasMyStore
    {
        [Fact]
        public void AutomacaoSifth()
        {
            IWebDriver navegador = new ChromeDriver();
            navegador.Manage().Window.Maximize();

            navegador.Navigate().GoToUrl("http://automationpractice.com/index.php");

            navegador.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
            navegador.FindElement(By.XPath("//*[@id='email']")).SendKeys("desafio.shift@gmail.com");
            navegador.FindElement(By.XPath("//*[@id='passwd']")).SendKeys("automacao01");
            navegador.FindElement(By.XPath("//*[@id='SubmitLogin']")).Click();
            navegador.FindElement(By.XPath("//*[@id='header_logo']/a/img")).Click();
            navegador.FindElement(By.XPath("//*[@id='search_query_top']")).SendKeys("Blouse" + Keys.Enter);
            navegador.FindElement(By.XPath("//*[@id='list']")).Click();
            navegador.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div/div[3]/div/div[2]/a[1]")).Click();
            Thread.Sleep(2000);
            navegador.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")).Click();
            navegador.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]")).Click();
            navegador.FindElement(By.XPath("//*[@id='center_column']/form/p/button")).Click();
            navegador.FindElement(By.Id("cgv")).Click();
            navegador.FindElement(By.XPath("//*[@id='form']/p/button")).Click();
            navegador.FindElement(By.ClassName("cheque")).Click();
            navegador.FindElement(By.XPath("//*[@id='cart_navigation']/button")).Click();
            Thread.Sleep(2000);

            string MensagemSucesso;
            MensagemSucesso = navegador.FindElement(By.XPath("//*[@id='center_column']/p[1]")).Text;
            Assert.Equal("Your order on My Store is complete.", MensagemSucesso);

            navegador.Quit();

        }
    }
}
