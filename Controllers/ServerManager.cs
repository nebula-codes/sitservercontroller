
using SitServerController.Common;
using SitServerController.Models;

namespace SitServerController.Controllers;


public static class ServerManager
{
    public static ServerInfo SelectedServer { get; private set; } = null;

    public static bool PingServer()
    {
        string json = "";

        try
        {
            json = RequestHandler.SendPing();

            if(json != null) return true;
        }
        catch
        {
            return false;
        }

        return false;
    }

    public static string GetVersion()
    {
        try
        {
            string json = RequestHandler.RequestServerVersion();

            return Json.Deserialize<string>(json);
        }
        catch
        {
            return "";
        }
    }

    public static string GetCompatibleGameVersion()
    {
        try
        {
            string json = RequestHandler.RequestCompatibleGameVersion();

            return Json.Deserialize<string>(json);
        }
        catch
        {
            return "";
        }
    }

    public static void LoadServer(string backendUrl)
    {
        string json = "";

        try
        {
            RequestHandler.ChangeBackendUrl(backendUrl);
            json = RequestHandler.RequestConnect();
        }
        catch
        {
            SelectedServer = null;
            return;
        }

        SelectedServer = Json.Deserialize<ServerInfo>(json);
    }

    public static async Task LoadDefaultServerAsync(string server)
    {
        await Task.Run(() =>
        {
            LoadServer(server);
        });
    }
}