using Logic;

internal class Program
{
    private static void Main(string[] args)
    {
        IHTMLProvider hTMLProvider = new RestHTMLProvider("https://schools.risd.org/BowieES/school-supply-list/");
        HTMLMethadataExtracter extracter = new HTMLMethadataExtracter(hTMLProvider);
        int lines = extracter.CountLines();
        int divCount = extracter.CountHTMLTags(HTMLTag.div);
    }
}