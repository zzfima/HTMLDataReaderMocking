namespace Logic
{
    public class FileHTMLProvider : IHTMLProvider
    {
        private readonly string _path;

        public FileHTMLProvider(string path) => _path = path;

        public async Task<string> ReadHTMLAsync()
        {
            string page = await File.ReadAllTextAsync(_path);
            return page;
        }
    }
}
