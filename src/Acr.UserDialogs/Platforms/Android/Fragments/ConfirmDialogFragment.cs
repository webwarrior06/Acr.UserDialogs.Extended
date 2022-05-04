using System;
using Acr.UserDialogs.Extended.Builders;
using Android.App;
using Android.Content;
using Android.Views;


namespace Acr.UserDialogs.Extended.Fragments
{
    public class ConfirmAppCompatDialogFragment : AbstractAppCompatDialogFragment<ConfirmConfig>
    {
        protected override void OnKeyPress(object sender, DialogKeyEventArgs args)
        {
            base.OnKeyPress(sender, args);
            if (args.KeyCode != Keycode.Back)
                return;

            args.Handled = true;
            this.Config?.OnAction?.Invoke(false);
            this.Dismiss();
        }


        protected override Dialog CreateDialog(ConfirmConfig config)
        {
            return new ConfirmBuilder().Build(this.AppCompatActivity, config);
        }
    }
}
