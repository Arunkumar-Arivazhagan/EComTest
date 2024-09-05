
using Framework_Oritain.Driver;
using Oritain_project.Pages;

namespace Oritain_project;

public class LoginTest
{
    private IHomePage _homePage;
    private readonly ILoginPage _loginPage;
    
    public LoginTest(IHomePage homePage, ILoginPage loginPage)
    {
        _homePage = homePage;
        _loginPage = loginPage;
    }
    
    [Theory]
    [InlineData("jsmith","demo1234")]
    [InlineData("admin","admin")]
    public void LoginValid(string username, string password)
    {
        _loginPage.loginCred(username, password);
        _loginPage.ClickLogin();
        
        //Assertion
        _homePage.validateLogin();
    }
}