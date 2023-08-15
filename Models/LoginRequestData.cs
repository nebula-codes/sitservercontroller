namespace SitServerController.Models;

public struct LoginRequestData
{
    public string username;
    public string password;

    public LoginRequestData(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
}
