using Framework_Oritain.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_Oritain.Driver;

public class DriverWait : IDriverWait
{
    private readonly IDriverFixture _driverFixture;
    private readonly TestSettings? _testSettings;
    private readonly Lazy<WebDriverWait> _webDriverWait;
    private IDriverWait _driverWaitImplementation;

    public DriverWait(IDriverFixture driverFixture, TestSettings? testSettings)
    {
        _driverFixture = driverFixture;
        _testSettings = testSettings;
        _webDriverWait = new Lazy<WebDriverWait>(GetWaitDriver);
    }

    public IWebElement FindElement(By elementLocator)
    {
        return _webDriverWait.Value.Until(_ => _driverFixture.Driver.FindElement((elementLocator)));
    }
    
    private WebDriverWait GetWaitDriver()
    {
        return new WebDriverWait(_driverFixture.Driver,
            timeout: TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 30))
        {
            PollingInterval = TimeSpan.FromSeconds(_testSettings.TimeoutInterval ?? 1)
        };
    }
}

public interface IDriverWait
{
    IWebElement FindElement(By elementLocator);
}