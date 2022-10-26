using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FivePlusThreeIsEight()
        {
            Assert.Equal(8, Calculator.Add(3, 5));
        }

        public void  SevenPlusFiveIsThirteen()
        {
            Assert.Equal(13, Calculator.Add(7, 5));
        }
    }
}
