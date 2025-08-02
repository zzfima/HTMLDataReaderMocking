using Logic;

internal class Program
{
    private static void Main(string[] args)
    {
        IHTMLProvider hTMLProvider = new FileHTMLProvider("BowieElementarySchoolPage.txt");
        IHTMLMethadataExtracter extracter = new HTMLMethadataExtracter(hTMLProvider);
        int lines = extracter.CountLines();
        int divCount = extracter.CountHTMLTags(HTMLTag.div);
    }
}