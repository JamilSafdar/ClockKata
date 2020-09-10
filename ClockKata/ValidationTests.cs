using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClockKata
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void GivenAValidHour_ThenReturnTrue()
        {
            //arrange
            var hour = 0;
            var expectedResult = true;

            //act

            var actualResult = new Validation().IsHourValid(hour);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenAnInvalidHour_ThenReturnFalse()
        {
            //arrange
            var hour = 24;
            var expectedResult = false;

            //act

            var actualResult = new Validation().IsHourValid(hour);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenAValidMinute_ThenReturnTrue()
        {
            //arrange
            var minute = 29;
            var expectedResult = true;

            //act

            var actualResult = new Validation().IsMinuteValid(minute);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenAnInvalidMinute_ThenReturnFalse()
        {
            //arrange
            var minute = 61;
            var expectedResult = false;

            //act

            var actualResult = new Validation().IsMinuteValid(minute);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenAValidSecond_ThenReturnTrue()
        {
            //arrange
            var second = 45;
            var expectedResult = true;

            //act

            var actualResult = new Validation().IsSecondValid(second);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GivenAnInvalidSecond_ThenReturnFalse()
        {
            //arrange
            var second = 100;
            var expectedResult = false;

            //act

            var actualResult = new Validation().IsSecondValid(second);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
