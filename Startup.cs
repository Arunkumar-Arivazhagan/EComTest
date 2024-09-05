using Framework_Oritain.Config;
using Framework_Oritain.Driver;
using Microsoft.Extensions.DependencyInjection;
using Oritain_project.Pages;
using IDriverFixture = Framework_Oritain.Driver.IDriverFixture;

namespace Oritain_project;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddSingleton(ConfigReader.ReadConfig())
            .AddScoped<IDriverFixture, DriverFixture>()
            .AddScoped<IDriverWait, DriverWait>()
            .AddScoped<IHomePage, HomePage>()
            .AddScoped<ILoginPage, LoginPage>();
    }
}