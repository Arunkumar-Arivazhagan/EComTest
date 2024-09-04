using OpenQA.Selenium;

namespace Oritain_project.Pages;

public class HomePage
{
    private readonly IWebDriver _driver;
    public HomePage(IWebDriver driver)
    {
        _driver = driver;
    }

    public IWebElement welcomeText => _driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[2]/div/p"));
    
}