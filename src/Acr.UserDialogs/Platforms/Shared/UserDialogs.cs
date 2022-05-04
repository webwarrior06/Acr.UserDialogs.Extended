using System;
namespace Acr.UserDialogs.Extended.Platforms.Shared
{
    public static partial class UserDialogs
    {
        #if NETSTANDARD
        static IUserDialogs currentInstance;
        public static IUserDialogs Instance
        {
            get
            {
                if (currentInstance == null)
                    throw new ArgumentException("[Acr.UserDialogs.Extended] This is the bait library, not the platform library.  You must install the nuget package in your main executable/application project");

                return currentInstance;
            }
            set => currentInstance = value;
        }
        #endif
    }
}
