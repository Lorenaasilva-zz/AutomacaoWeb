using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public class HomePage
{
    private IWebDriver driver;
    private By BySearch;
    private By ByList;
    private By ByAddCard;
    private By ByProceedCard;

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        BySearch = By.XPath("//input[@id='search_query_top']");
        ByList = By.XPath("//li[@id='list']");
        ByAddCard = By.XPath("//a[@class='button ajax_add_to_cart_button btn btn-default']");
        ByProceedCard = By.XPath("//a[@title='Proceed to checkout']");
    }


    public void BuscarProduto()
    {
        driver.FindElement(BySearch).SendKeys("blouse");
        driver.FindElement(BySearch).SendKeys(Keys.Enter);
    }

    public void AdicionarCarrinho()
    {
        driver.FindElement(ByList).Click();
        driver.FindElement(ByAddCard).Click();
    }

    public void IrAoCarrinho()
    {
        driver.FindElement(ByProceedCard).Click();
    }


}

