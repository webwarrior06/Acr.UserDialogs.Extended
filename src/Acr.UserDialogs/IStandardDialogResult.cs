namespace Acr.UserDialogs.Extended
{
    public interface IStandardDialogResult<T>
    {
        bool Ok { get; }
        T Value { get; }
    }
}
