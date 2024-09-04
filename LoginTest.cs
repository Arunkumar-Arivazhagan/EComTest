using Framework_Oritain.Config;
using Framework_Oritain.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Oritain_project.Pages;

namespace Oritain_project;

public class LoginTest : IDisposable
{
    private IWebDriver _driver;
    public LoginTest()
    {
        var testSettings = new TestSettings
        {
            BrowserType = DriverFixture.BrowserType.Chrome,
            ApplicationUrl = new Uri("http://demo.testfire.net/login.jsp"),
            TimeoutInterval = 30
        };
        _driver = new DriverFixture(testSettings).Driver;
    }
    
    [Theory]
    [InlineData("jsmith","demo1234")]
    [InlineData("admin","admin")]
    public void Test2(string username, string password)
    {
        var loginPage = new LoginPage(_driver);
        var homePage = new HomePage(_driver);
        
        loginPage.loginCred(username, password);
        loginPage.ClickLogin();
        
        //Assertion
        Assert.True(homePage.welcomeText.Displayed, "Welcome to Altoro Mutual Online.");
    }
    
    public void Dispose()
    {
        _driver?.Quit();
    }
}