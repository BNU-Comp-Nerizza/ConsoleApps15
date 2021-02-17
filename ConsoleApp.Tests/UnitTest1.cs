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

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double exptectedDistance = 3.28084;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 3.28084;
            converter.CalculateDistance();

            double exptectedDistance = 1.0;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double exptectedDistance = 1609.34;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 1609.34;
            converter.CalculateDistance();

            double exptectedDistance = 1.0;

            Assert.AreEqual(exptectedDistance, converter.ToDistance);
        }

    }
}
