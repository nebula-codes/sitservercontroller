

namespace SitServerController.Models;



public class Server
{

    public string Name { get; set; }
    public string HttpUrl { get; set; }
    public string[] Editions { get; set; }
    public Dictionary<string,string> ProfileDescriptions { get; set; }

    public string LoginUsername { get; set; }
    public string LoginPassword { get; set; }
    
    public Server()
    {
        string value;
        string user;
        string pass;
        IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();
        IConfigurationProvider provider = config.Providers.ToList().First(); //There could be several providers but in my case I have only one
        provider.Load();//reloads the content of the appSettings.json
        provider.TryGet("BackendServerURL", out value);
        provider.TryGet("AdminUsername", out user);
        provider.TryGet("AdminPassword", out pass);
        LoginUsername = user;
        LoginPassword = pass;
        HttpUrl = value;
    }
    
}