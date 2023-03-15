using CountTheDigit.BL;

namespace CountTheDigit.Test
{
    public class DigitCounterTest
    {
        [Theory]
        [InlineData(10, 1, 4)]
        [InlineData(5750, 0, 4700)]
        [InlineData(11011, 2, 9481)]
        [InlineData(12224, 8, 7733)]
        [InlineData(11549, 1, 11905)]
        public void NbDigtest(int stop, int key, int expected)
        {
            //arrange
            IDigitCounter counter = new DigitCounter();

            //act
            int actual = counter.NbDig(stop, key);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}