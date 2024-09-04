using Framework_Oritain.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace Framework_Oritain.Driver;

public class DriverFixture
{
    private readonly TestSettings _testSettings;
    public IWebDriver Driver { get;  }
    public DriverFixture(TestSettings testSettings)
    {
        _testSettings = testSettings;
        Driver = GetDriverType(_testSettings.BrowserType);
        //navigate to the website
        Driver.Navigate().GoToUrl(_testSettings.ApplicationUrl);
    }
    private IWebDriver GetDriverType(BrowserType browserType)
    {
        return browserType switch
        {
            BrowserType.Chrome => new ChromeDriver(),
            BrowserType.Firefox => new FirefoxDriver(),
            BrowserType.EdgeChromium => new EdgeDriver(),
            _ => new ChromeDriver(),
        };
    }

    public enum BrowserType
    {
        Chrome,
        Firefox,
        EdgeChromium,
    }
}