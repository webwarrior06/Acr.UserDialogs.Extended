namespace Acr.UserDialogs.Extended
{

    public class PromptResult : AbstractStandardDialogResult<string>
    {
        public PromptResult(bool ok, string text) : base(ok, text)
        {
        }


        public string Text => this.Value;
    }
}
