using UnitTesting;

namespace xUnitTest
{
    public class DomainLogicTests
    {
        private readonly DomainLogic domain;
        public DomainLogicTests()
        {
            //SUT(System under test)
            domain = new DomainLogic();
        }
        [Fact]
        public void Domain_ReturnZero_String()
        {
            //Arrange
            int n = 0;
            //Action
            string result = domain.ReturnZero(n);
            //Assert
            //Assert.Equal(expectedValue, Actual Value);
            Assert.Equal("hi successfull", result);
        }

        [Fact]
        public void Domain_ReturnOne_String()
        {
            //Arrange
            int n = 0;

            //Action
            string result = domain.ReturnZero(n);
            //Assert
            //Assert.Equal(expectedValue, Actual Value);
            Assert.Contains("hi", result);
        }
    }
}