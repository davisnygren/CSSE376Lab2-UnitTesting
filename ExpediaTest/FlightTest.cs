using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        DateTime startDate = DateTime.Parse("2015-3-20");
        DateTime endDate = DateTime.Parse("2015-3-22");
        int miles = 700;

        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(startDate, endDate, miles);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForZeroDaySpread()
        {
            var target = new Flight(DateTime.Parse("2015-3-20"),
                DateTime.Parse("2015-3-20"), 700);
            Assert.AreEqual(200, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDaySpread()
        {
            var target = new Flight(DateTime.Parse("2015-3-20"),
                DateTime.Parse("2015-3-21"), 700);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDaySpread()
        {
            var target = new Flight(DateTime.Parse("2015-3-20"), 
                DateTime.Parse("2015-3-22"), 700);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDaySpread()
        {
            var target = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-25"), 1200);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        public void TestEqualsTrue()
        {
            var targetA = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-25"), 1200);
            var targetB = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-25"), 1200);
            Assert.AreEqual(targetA, targetB);
        }

        [Test()]
        public void TestEqualsFalse()
        {
            var targetA = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-25"), 1200);
            var targetB = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-15"), 1200);
            Assert.AreNotEqual(targetA, targetB);
        }

        [Test()]
        public void TestEqualsNonFlight()
        {
            var targetA = new Flight(DateTime.Parse("2015-3-15"),
                DateTime.Parse("2015-3-25"), 1200);
            var targetB = 15;
            Assert.AreNotEqual(targetA, targetB);
        }

	}
}
