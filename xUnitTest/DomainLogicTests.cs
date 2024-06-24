using UnitTesting;

namespace xUnitTest
{
    public class DomainLogicTests
    {
        [Fact]
        public void Domain_ReturnZero_String()
        {
                //Arrange
                int n = 0;
                DomainLogic domain = new DomainLogic();


                //Action
                string result = domain.ReturnZero(n);


                //Assert
                //Assert.Equal(expectedValue, Actual Value);
                Assert.Equal("successfull", result);
        }
    }
}