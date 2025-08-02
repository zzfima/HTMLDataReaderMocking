namespace Logic
{
    public class RestHTMLProvider : IHTMLProvider
    {
        private readonly string _url;

        public RestHTMLProvider(string url) => _url = url;

        public async Task<string> ReadHTMLAsync()
        {
            HttpClient client = new HttpClient();
            string page = await client.GetStringAsync(_url);
            return page;
        }
    }
}
