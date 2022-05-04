using Acr.UserDialogs.Extended;
using Samples.ViewModels;
using Xamarin.Forms;

namespace Samples.Pages
{
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();

            // the idea here is that you would dependency inject userdialogs
            this.BindingContext = new ProgressViewModel(UserDialogs.Instance);
        }
    }
}
