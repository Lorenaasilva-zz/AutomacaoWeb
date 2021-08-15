using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

public class ShoppingCartPage
{
    private IWebDriver driver;
    private By BySummary;
    private By ByAdress;
    private By ByTermsService;
    private By ByShipping;
    private By ByPaymant;
    private By ByConfirmPaymant;

    public ShoppingCartPage (IWebDriver driver)
    {
        this.driver = driver;
        BySummary = By.XPath("//*[@id='center_column']/p[2]/a[1]");
        ByAdress = By.XPath("//button[@name='processAddress']");
        ByTermsService = (By.XPath("//input[@name='cgv']"));
        ByShipping = (By.XPath("//button[@name='processCarrier']"));
        ByPaymant = (By.XPath("//a[@class='cheque']"));
        ByConfirmPaymant = (By.XPath("//button[@class='button btn btn-default button-medium']"));

    }


    public void FinalizarCompra()
    {
        driver.FindElement(BySummary).Click();
        driver.FindElement(ByAdress).Click();
        driver.FindElement(ByTermsService).Click();
        driver.FindElement(ByShipping).Click();
        driver.FindElement(ByPaymant).Click();
        driver.FindElement(ByConfirmPaymant).Click();
    }


}
