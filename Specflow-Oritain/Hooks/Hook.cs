using System;
using TechTalk.SpecFlow;

namespace Specflow_Oritain.Hooks
{
    [Binding]
    public class Hooks
    {
        private IHomePage _homePage;
        private readonly ILoginPage _loginPage;
        
        public Hooks(IHomePage homePage, ILoginPage loginPage)
        {
            _homePage = homePage;
            _loginPage = loginPage;
        }
        [Given(@"Enter valid username and password")]
        public void GivenEnterValidUsernameAndPassword(string username, string password)
        {
            _loginPage.loginCred(username, password);
        }

        [When(@"Click on login button")]
        public void WhenClickOnLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"Verify login is successful")]
        public void ThenVerifyLoginIsSuccessful()
        {
            _homePage.validateLogin();
        }
    }
}