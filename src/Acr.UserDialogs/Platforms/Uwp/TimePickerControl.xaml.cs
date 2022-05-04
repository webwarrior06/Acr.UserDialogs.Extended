using System;
using Windows.UI.Xaml.Controls;


namespace Acr.UserDialogs.Extended
{
    public sealed partial class TimePickerControl
    {
        public TimePickerControl()
        {
            this.InitializeComponent();
        }


        public Button OkButton => this.btnOk;
        public Button CancelButton => this.btnCancel;
        public TimePicker TimePicker => this.timePicker;
    }
}
