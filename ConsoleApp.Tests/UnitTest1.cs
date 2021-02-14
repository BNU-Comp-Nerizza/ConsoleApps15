using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double exptectedDistance = 5280;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 5280;
            converter.CalculateDistance();

            double exptectedDistance = 1.0;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }
    }
}
