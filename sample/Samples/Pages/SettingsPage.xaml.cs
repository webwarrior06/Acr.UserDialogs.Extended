﻿using Acr.UserDialogs.Extended;
using Samples.ViewModels;
using Xamarin.Forms;

namespace Samples.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            // the idea here is that you would dependency inject userdialogs
            this.BindingContext = new SettingsViewModel(UserDialogs.Instance);
        }
    }
}
