using SitServerController.Common;
using SitServerController.Models;

namespace SitServerController.Controllers;

public enum AccountStatus
    {
        OK = 0,
        NoConnection = 1,
        LoginFailed = 2,
        RegisterFailed = 3,
        UpdateFailed = 4
    }

    public static class AccountManager
    {
        private const string STATUS_FAILED = "FAILED";
        private const string STATUS_OK = "OK";
        public static AccountInfo SelectedAccount { get; private set; } = null;

        public static void Logout() => SelectedAccount = null;

        public static async Task<AccountStatus> LoginAsync(LoginModel Creds)
        {
            return await Task.Run(() =>
            {
                return Login(Creds.Username, Creds.Password);
            });
        }

        public static async Task<AccountStatus> LoginAsync(string username, string password)
        {
            return await Task.Run(() =>
            {
                return Login(username, password);
            });
        }

        public static AccountStatus Login(string username, string password)
        {
            LoginRequestData data = new LoginRequestData(username, password);
            string id = STATUS_FAILED;
            string json = "";

            try
            {
                id = RequestHandler.RequestLogin(data);

                if (id == STATUS_FAILED)
                {
                    return AccountStatus.LoginFailed;
                }

                json = RequestHandler.RequestAccount(data);
            }
            catch
            {
                return AccountStatus.NoConnection;
            }

            SelectedAccount = Json.Deserialize<AccountInfo>(json);
            RequestHandler.ChangeSession(SelectedAccount.id);
            
            return AccountStatus.OK;
        }



        public static PlayerInformation[] GetExistingProfiles()
        {
            string profileJsonArray = RequestHandler.RequestExistingProfiles();

            if(profileJsonArray != null)
            {
                PlayerInformation[] miniProfiles = Json.Deserialize<PlayerInformation[]>(profileJsonArray);

                if (miniProfiles != null && miniProfiles.Length > 0)
                {
                    return miniProfiles;
                }
            }

            return new PlayerInformation[0];
        }

        public static async Task<AccountStatus> RegisterAsync(string username, string password, string edition)
        {
            return await Task.Run(() =>
            {
                return Register(username, password, edition);
            });
        }

        public static AccountStatus Register(string username, string password, string edition)
        {
            RegisterRequestData data = new RegisterRequestData(username, password, edition);
            string registerStatus = STATUS_FAILED;

            try
            {
                registerStatus = RequestHandler.RequestRegister(data);

                if (registerStatus != STATUS_OK)
                {
                    return AccountStatus.RegisterFailed;
                }
            }
            catch
            {
                return AccountStatus.NoConnection;
            }

            return Login(username, password);
        }

        //only added incase wanted for future use.
        public static async Task<AccountStatus> RemoveAsync()
        {
            return await Task.Run(() =>
            {
                return Remove();
            });
        }
        
        public static async Task<AccountStatus> RemoveAsync(string username, string password)
        {
            return await Task.Run(() =>
            {
                return Remove(username, password);
            });
        }

        public static AccountStatus Remove()
        {
            LoginRequestData data = new LoginRequestData(SelectedAccount.username, SelectedAccount.password);

            try
            {
                string json = RequestHandler.RequestRemove(data);

                if(Json.Deserialize<bool>(json))
                {
                    SelectedAccount = null;

                    return AccountStatus.OK;
                }
                else
                {
                    return AccountStatus.UpdateFailed;
                }
            }
            catch
            {
                return AccountStatus.NoConnection;
            }
        }
        
        public static AccountStatus Remove(string username, string password)
        {
            LoginRequestData data = new LoginRequestData(username, password);

            try
            {
                string json = RequestHandler.RequestRemove(data);

                if(Json.Deserialize<bool>(json))
                {
                    SelectedAccount = null;

                    return AccountStatus.OK;
                }
                else
                {
                    return AccountStatus.UpdateFailed;
                }
            }
            catch
            {
                return AccountStatus.NoConnection;
            }
        }


        public static async Task<AccountStatus> WipeAsync(string edition)
        {
            return await Task.Run(() =>
            {
                return Wipe(edition);
            });
        }

        public static AccountStatus Wipe(string edition)
        {
            RegisterRequestData data = new RegisterRequestData(SelectedAccount.username, SelectedAccount.password, edition);
            string json = STATUS_FAILED;

            try
            {
                json = RequestHandler.RequestWipe(data);

                if (json != STATUS_OK)
                {
                    return AccountStatus.UpdateFailed;
                }
            }
            catch
            {
                return AccountStatus.NoConnection;
            }

            SelectedAccount.edition = edition;
            return AccountStatus.OK;
        }
    }