using Logic;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodNoMocking()
        {
            IHTMLProvider hTMLProvider = new FileHTMLProvider("../../../../Client/bin/Debug/net8.0/BowieElementarySchoolPage.txt");
            HTMLMethadataExtracter extracter = new HTMLMethadataExtracter(hTMLProvider);
            int lines = extracter.CountLines();
            int divCount = extracter.CountHTMLTags(HTMLTag.div);

            Assert.IsTrue(lines == 1027, "Line count should be greater than 0");
            Assert.IsTrue(divCount == 182, "Div count should be greater than 0");
        }
    }
}
