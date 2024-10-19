using Prime.Services;

namespace PrimeServiceTests
{
    public class PrimeService_IsPrimeShould
    {
        #region Sample_TestCode
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {

            var result = PrimeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = PrimeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }


        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var result = PrimeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

    }
}