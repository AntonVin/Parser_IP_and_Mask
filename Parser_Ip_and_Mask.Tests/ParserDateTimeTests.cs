using Parser_Ip_and_Mask;
using Xunit;
namespace Parser_Ip_and_Mask.Tests
{
    public class ParserDateTimeTests
    {
        [Fact]
        public void Parse_Typical()
        {
            //Arrange
            var expected = new DateTime(2024,4,5,9,20,5,940);
            //Act
            var actual = ParserDateTime.Parse("ss725-rt-c4221-2--Apr--5-09-20-05.940-MSK-0");
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}