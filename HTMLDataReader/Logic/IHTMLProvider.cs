namespace Logic
{
    public interface IHTMLProvider
    {
        Task<string> ReadHTMLAsync();
    }
}
