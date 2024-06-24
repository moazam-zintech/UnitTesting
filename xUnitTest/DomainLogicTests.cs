using FluentAssertions;
using FluentAssertions.Extensions;
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
        //Naming Convention should be like First Class Name slash Method Name slash and Return Type
        public void Domain_ReturnZero_ReturnString()
        {
            //Arrange
            int n = 0;
            //Action
            string result = domain.ReturnZero(n);
            //Assert
            //Assert.Equal(expectedValue, Actual Value);
            Assert.Equal("hi successfull", result);
            Assert.Contains("hi", result);
        }
        [Fact]
        public void DomainLogics_TodayDate_ReturnDate()
        {
            //Arrange


            //Action
            var result = domain.ReturnDate();
            //Assert
            //Assert.Equal(expectedValue, Actual Value);
            result.Should().BeBefore(10.January(2089));
        }
    }
}