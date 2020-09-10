using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockKata
{
    [TestClass]
    public class ClockTests
    {
        [TestMethod]
        public void GivenTimeInhms_ThenReturnConvertedTimeInMilliseconds()
        {
            //arrange
            var hours = 0;
            var minutes = 1;
            var seconds = 1;

            var expectedResult = 61000;

            //act
            var actualResult = Clock.ConvertTimehmsToMillseconds(hours, minutes, seconds);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
