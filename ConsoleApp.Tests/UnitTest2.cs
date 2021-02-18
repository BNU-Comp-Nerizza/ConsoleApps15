using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBmiCalculator
    {
        [TestMethod]
        public void TestMetricUnderweightLow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 45.5;
            calculator.Centimetres = 193;
            calculator.CalculateMetric();

            double expectedIndex = 12;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex,0));
        }

        [TestMethod]
        public void TestMetricUnderweightHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 56.8;
            calculator.Centimetres = 177.8;
            calculator.CalculateMetric();

            double expectedIndex = 18;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialUnderweightLow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 6;
            calculator.Inch = 4;
            calculator.Pound = 100;
            calculator.CalculateImperial();

            double expectedIndex = 12;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialUnderweightHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 8;
            calculator.Pound = 120;
            calculator.CalculateImperial();

            double expectedIndex = 18;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricNormalLow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 61.4;
            calculator.Centimetres = 180.3;
            calculator.CalculateMetric();

            double expectedIndex = 19;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricNormalHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 65.9;
            calculator.Centimetres = 162.5;
            calculator.CalculateMetric();

            double expectedIndex = 25;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 1));
        }

        [TestMethod]
        public void TestImperialNormalLow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 6;
            calculator.Inch = 3;
            calculator.Pound = 150;
            calculator.CalculateImperial();

            double expectedIndex = 19;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialNormaHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound = 125;
            calculator.CalculateImperial();

            double expectedIndex = 24;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricOverweightLow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 65.9;
            calculator.Centimetres = 160;
            calculator.CalculateMetric();

            double expectedIndex = 26;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricOverweightHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 79.5;
            calculator.Centimetres = 165.1;
            calculator.CalculateMetric();

            double expectedIndex = 29;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }


        [TestMethod]
        public void TestImperialOverweightLow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 8;
            calculator.Pound = 170;
            calculator.CalculateImperial();

            double expectedIndex = 26;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialOverweightHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 7;
            calculator.Pound = 185;
            calculator.CalculateImperial();

            double expectedIndex = 29;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseILow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 72.7;
            calculator.Centimetres = 154.9;
            calculator.CalculateMetric();

            double expectedIndex = 30;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseIHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 79.5;
            calculator.Centimetres = 152.4;
            calculator.CalculateMetric();

            double expectedIndex = 34;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialObeseILow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound =155;
            calculator.CalculateImperial();

            double expectedIndex = 30;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialObeseIHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound = 175;
            calculator.CalculateImperial();

            double expectedIndex =34;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseIILow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 84.1;
            calculator.Centimetres = 154.9;
            calculator.CalculateMetric();

            double expectedIndex = 35;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseIIHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 90.9;
            calculator.Centimetres = 152.4;
            calculator.CalculateMetric();

            double expectedIndex = 39;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialObeseIILow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 1;
            calculator.Pound = 185;
            calculator.CalculateImperial();

            double expectedIndex = 35;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex,0));
        }

        [TestMethod]
        public void TestImperialObeseIIHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound = 200;
            calculator.CalculateImperial();

            double expectedIndex = 39;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseIIILow()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 95.5;
            calculator.Centimetres = 154.9;
            calculator.CalculateMetric();

            double expectedIndex = 40;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestMetricObeseIIIHigh()
        {
            BMI calculator = new BMI();
            calculator.Kilograms = 97.7;
            calculator.Centimetres = 152.4;
            calculator.CalculateMetric();

            double expectedIndex = 42;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialObeseIIILow()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound = 205;
            calculator.CalculateImperial();

            double expectedIndex = 40;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }

        [TestMethod]
        public void TestImperialObeseIIIHigh()
        {
            BMI calculator = new BMI();
            calculator.Feet = 5;
            calculator.Inch = 0;
            calculator.Pound = 215;
            calculator.CalculateImperial();

            double expectedIndex = 42;

            Assert.AreEqual(expectedIndex, Math.Round(calculator.BmiIndex, 0));
        }
    }
}
