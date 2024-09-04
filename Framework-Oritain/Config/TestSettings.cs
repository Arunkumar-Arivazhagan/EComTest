using Framework_Oritain.Driver;

namespace Framework_Oritain.Config;

public class TestSettings
{
    public DriverFixture.BrowserType BrowserType { get; set; }
    
    public Uri ApplicationUrl { get; set; }
    
    public float? TimeoutInterval { get; set; }
}