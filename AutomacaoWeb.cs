using DesafioShift.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace AutomacaoWeb
{
    public class ComprasMyStore
    {
        [Fact]
        public void RealizarCompraTodosPassos()
        {
            IWebDriver driver = new ChromeDriver();

            //Autenticação do usuário
            var loginPage = new LoginPage(driver);
            loginPage.AbrirPagina();
            loginPage.SignIn();
            loginPage.PreencheDadosLogin();
            loginPage.SubmeterLogin();
            loginPage.BackHome();

            //Adicionar produto ao carrinho
            var homePage = new HomePage(driver);
            homePage.BuscarProduto();
            homePage.AdicionarCarrinho();
            Thread.Sleep(2000);
            homePage.IrAoCarrinho();

            //Finalizar compras no carrinho
            var shoppingCartPage = new ShoppingCartPage(driver);
            shoppingCartPage.FinalizarCompra();

            Thread.Sleep(1000);
            Assert.Contains("Order confirmation - My Store", driver.Title);

            driver.Close();

        }

        
    }
}
