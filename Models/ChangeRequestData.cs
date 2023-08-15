namespace SitServerController.Models;

public struct ChangeRequestData
{
    public string username;
    public string password;
    public string change;

    public ChangeRequestData(string username, string password, string change)
    {
        this.username = username;
        this.password = password;
        this.change = change;
    }
}