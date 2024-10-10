namespace CalculationsTests
{
    [TestClass]
    public class UnitTest1
    {
        string[] startTimes = { "10:00", "11:00", "15:00", "15:30", "16:50" };
        string[] emptyStartTimes = { };
        int[] durations = { 60, 30, 10, 10, 40 };
        int[] emptyDurations = { };
        string
        beginWorkingTime = "08:00";
        string
        endWorkingTime = "18:00";
        int consultationTime = 30;

        [TestMethod]
        public void AssertLength()
        {
            string[] expected = { "08:00 - 08:30", "08:30 - 09:00", "09:00 - 09:30", "09:30 - 10:00", "11:30 - 12:00", "12:00 - 12:30", "12:30 - 13:00", "13:00 - 13:30", "13:30 - 14:00", "14:00 - 14:30", "14:30 - 15:00", "15:40 - 16:10", "16:10 - 16:40", "17:30 - 18:00" };
            string[] actual = Calculations.Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            Assert.AreEqual(expected.Length, actual.Length);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AssertCollections()
        {
            string[] expected = { "08:00 - 08:30", "08:30 - 09:00", "09:00 - 09:30", "09:30 - 10:00", "11:30 - 12:00", "12:00 - 12:30", "12:30 - 13:00", "13:00 - 13:30", "13:30 - 14:00", "14:00 - 14:30", "14:30 - 15:00", "15:40 - 16:10", "16:10 - 16:40", "17:30 - 18:00" };
            string[] actual = Calculations.Calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassEmptyStartTimes()
        {
            string[]? expected = null;
            string[] actual = Calculations.Calculations.AvailablePeriods(emptyStartTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassEmptyDurations()
        {
            string[]? expected = null;
            string[] actual = Calculations.Calculations.AvailablePeriods(startTimes, emptyDurations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}