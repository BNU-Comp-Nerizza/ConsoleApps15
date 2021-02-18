using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBmiCalculator
    {
        [TestMethod]
        public void TestMetricBmi()
        {
            BMI calculator = new BMI();

            calculator.unit = BMIUnit.Metric;
            calculator.Kilograms = 55;
            calculator.Centimetres = 160;
            calculator.CalculateMetric();

            double expectedIndex = 21.484374999999996;

            Assert.AreEqual(expectedIndex, calculator.BmiIndex);
        }


    }
}
