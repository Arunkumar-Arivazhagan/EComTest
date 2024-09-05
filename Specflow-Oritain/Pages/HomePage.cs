using Framework_Oritain.Driver;
using OpenQA.Selenium;

namespace Oritain_project.Pages;

public interface IHomePage
{
    public void validateLogin();
}

public class HomePage : IHomePage
{
    private readonly IDriverWait _driver;
    public HomePage(IDriverWait driver)
    {
        _driver = driver;
    }

    public IWebElement welcomeText => _driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[2]/div/p"));

    public void validateLogin()
    {
        Assert.True(welcomeText.Displayed, "Welcome to Altoro Mutual Online.");
    }
}