namespace SitServerController.Models;

public class ServerInfo
{
    public string backendUrl;
    public string name;
    public string[] editions;
    public Dictionary<string, string> profileDescriptions;

    public ServerInfo()
    {
        string value;
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        IConfigurationProvider provider = config.Providers.ToList().First(); //There could be several providers but in my case I have only one
        provider.Load();//reloads the content of the appSettings.json
        provider.TryGet("BackendServerURL", out value);
        backendUrl = value;

        name = "Local SPT-AKI Server";
        editions = new string[0];
        profileDescriptions = new Dictionary<string, string>();
    }
}