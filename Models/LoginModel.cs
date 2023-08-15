namespace SitServerController.Models;

public class LoginModel
{
    private string _Username = "";
    public string Username
    {
        get => _Username;
        set
        {
            if (_Username != value)
            {
                _Username = value;
            }
        }
    }

    private string _Password = "";
    public string Password
    {
        get => _Password;
        set
        {
            if (_Password != value)
            {
                _Password = value;
            }
        }
    } 
}