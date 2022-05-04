using System;
using Acr.UserDialogs.Extended.Platforms.macOS;
using AppKit;


namespace Acr.UserDialogs.Extended
{
    public static partial class UserDialogs
    {
        /// <summary>
        /// OPTIONAL: Initialize macOS user dialogs with your top window function
        /// </summary>
        public static void Init(Func<NSWindow> windowFunc)
        {
            Instance = new UserDialogsImpl(windowFunc);
        }


        static IUserDialogs currentInstance;
        public static IUserDialogs Instance
        {
            get
            {
                currentInstance = currentInstance ?? new UserDialogsImpl();
                return currentInstance;
            }
            set => currentInstance = value;
        }
    }
}
