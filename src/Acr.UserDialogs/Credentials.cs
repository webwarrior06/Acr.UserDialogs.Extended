﻿namespace Acr.UserDialogs.Extended
{
    public class Credentials
    {
        public Credentials(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }


        public string UserName { get; }
        public string Password { get; }
    }
}
