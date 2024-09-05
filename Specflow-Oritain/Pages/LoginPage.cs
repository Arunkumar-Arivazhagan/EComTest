using Framework_Oritain.Driver;
using OpenQA.Selenium;

namespace Oritain_project.Pages;

public interface ILoginPage
{
    void ClickLogin();
    void loginCred(string userId, string password);
}

public class LoginPage : ILoginPage
{
    private readonly IDriverWait _driver;
    public LoginPage(IDriverWait driver)
    {
        _driver = driver;
    }

    private IWebElement loginTextbox => _driver.FindElement(By.Id("uid"));
    
    private IWebElement passwordTextbox => _driver.FindElement(By.Id("passw"));
    private IWebElement loginBtn => _driver.FindElement(By.XPath("//input[@name='btnSubmit']"));

    public void ClickLogin() => loginBtn.Click();

    public void loginCred(string userId, string password)
    {
        loginTextbox.SendKeys(userId);
        passwordTextbox.SendKeys(password);
    }
}