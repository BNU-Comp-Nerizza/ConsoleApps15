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

            converter.fromUnit = DistanceUnits.Miles;
            converter.toUnit = DistanceUnits.Feet;

            converter.fromDistance = 1.0;
            converter.CalculateDistance();

            double exptectedDistance = 5280;

            Assert.AreEqual(exptectedDistance, converter.toDistance);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceUnits.Feet;
            converter.toUnit = DistanceUnits.Miles;

            converter.fromDistance = 5280;
            converter.CalculateDistance();

            double exptectedDistance = 1.0;

            Assert.AreEqual(exptectedDistance, converter.toDistance);
        }
    }
}
