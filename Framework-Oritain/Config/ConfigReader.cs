using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Framework_Oritain.Config;

public class ConfigReader
{
    public static TestSettings? ReadConfig()
    {
        var configFile =
            File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/appsettings.json");

        var jsonSerializeOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        jsonSerializeOptions.Converters.Add(new JsonStringEnumConverter());
        return JsonSerializer.Deserialize<TestSettings>(configFile, jsonSerializeOptions);
    }
}