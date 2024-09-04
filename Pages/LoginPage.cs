using Framework_Oritain.Driver;
using OpenQA.Selenium;

namespace Oritain_project.Pages;

public class LoginPage
{
    private readonly IWebDriver _driver;
    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement loginTextbox => _driver.FindElement(By.Id(""));
    
    private IWebElement passwordTextbox => _driver.FindElement(By.Id(""));
    private IWebElement loginBtn => _driver.FindElement(By.Id(""));

    public void ClickLogin() => loginBtn.Click();

    public void loginCred(string userId, string password)
    {
        loginTextbox.SendKeys(userId);
        passwordTextbox.SendKeys(password);
    }
}