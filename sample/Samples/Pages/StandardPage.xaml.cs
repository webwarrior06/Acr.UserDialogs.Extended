using Acr.UserDialogs.Extended.Platforms.Shared;
using Samples.ViewModels;
using Xamarin.Forms;

namespace Samples.Pages
{
    public partial class StandardPage : ContentPage
    {
        public StandardPage()
        {
            InitializeComponent();

            // the idea here is that you would dependency inject userdialogs
            this.BindingContext = new StandardViewModel(UserDialogs.Instance);
        }
    }
}
