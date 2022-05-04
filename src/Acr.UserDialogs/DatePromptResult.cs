using System;

namespace Acr.UserDialogs.Extended
{
    public class DatePromptResult : AbstractStandardDialogResult<DateTime>
    {
        public DatePromptResult(bool ok, DateTime selectedDate) : base(ok, selectedDate)
        {
        }


        public DateTime SelectedDate => this.Value;
    }
}
