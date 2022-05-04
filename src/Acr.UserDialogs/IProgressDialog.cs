using System;

namespace Acr.UserDialogs.Extended
{

    public interface IProgressDialog : IDisposable
    {
        string Title { get; set; }
        int PercentComplete { get; set; }
        bool IsShowing { get; }

        void Show();
        void Hide();
    }
}
