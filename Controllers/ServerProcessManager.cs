using System.Diagnostics;

namespace SitServerController.Controllers;

public class ServerProcessManager
{
    public bool IsUp { get; set; }
    public int ID { get; set; }
    public DateTime StartTime { get; set; }
    public string Name { get; set; }

    public bool IsServerUp()
    {
        Process proc = Process.GetProcessById(ID);
        return proc.Responding;
    }

    public bool StopServer()
    {
        try
        {
            if (IsUp)
            {
                Process proc = Process.GetProcessById(ID);
                proc.Kill();
                IsUp = false;
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public bool StartServer()
    {
        try
        {
            if (!IsUp)
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "/GameServer/Aki.Server.exe");
                Process proc = Process.Start(new ProcessStartInfo(path));
                ID = proc.Id;
                Name = proc.ProcessName;
                IsUp = true;
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }
}