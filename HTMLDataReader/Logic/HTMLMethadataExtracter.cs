namespace Logic
{
    public class HTMLMethadataExtracter
    {
        private readonly string _page;

        public HTMLMethadataExtracter(IHTMLProvider htmlProvider)
        {
            _page = htmlProvider.ReadHTMLAsync().GetAwaiter().GetResult();
        }

        public int CountLines() => _page.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

        public int CountHTMLTags(HTMLTag tag)
        {
            string tagName = tag.ToString().ToLowerInvariant();
            int divCount = 0;
            int index = 0;
            while ((index = _page.IndexOf($"<{tag}", index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                divCount++;
                index += tagName.Length;
            }
            return divCount;
        }
    }
}
