using Logic;
using Moq;

namespace Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodNoMocking()
        {
            //ARRANGE
            IHTMLProvider htmlProvider = new FileHTMLProvider("../../../../Client/bin/Debug/net8.0/BowieElementarySchoolPage.txt");
            IHTMLMethadataExtracter extracter = new HTMLMethadataExtracter(htmlProvider);

            //ACT
            int lines = extracter.CountLines();
            int divCount = extracter.CountHTMLTags(HTMLTag.div);

            //ASSERT
            Assert.IsTrue(lines == 1027, "Line count should be greater than 0");
            Assert.IsTrue(divCount == 182, "Div count should be greater than 0");
        }

        [TestMethod]
        public void TestMethodMockingIHTMLProvider()
        {
            //ARRANGE
            var mock = new Mock<IHTMLProvider>();
            string mockHtml = string.Concat(Enumerable.Repeat("line\n", 1027 - 182)) + string.Concat(Enumerable.Repeat("<div>\n", 182));

            mock.Setup(p => p.ReadHTMLAsync()).ReturnsAsync(mockHtml);
            IHTMLMethadataExtracter extracter = new HTMLMethadataExtracter(mock.Object);

            //ACT
            int lines = extracter.CountLines();
            int divCount = extracter.CountHTMLTags(HTMLTag.div);

            //ASSERT
            Assert.IsTrue(lines == 1027, "Line count should be greater than 0");
            Assert.IsTrue(divCount == 182, "Div count should be greater than 0");
        }
    }
}
