using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;


namespace Acr.UserDialogs.Extended
{
    public sealed partial class DatePickerControl
    {
        public DatePickerControl()
        {
            this.InitializeComponent();
        }


        public Button OkButton => this.btnOk;
        public Button CancelButton => this.btnCancel;
        public CalendarView DatePicker => this.datePicker;
    }
}
