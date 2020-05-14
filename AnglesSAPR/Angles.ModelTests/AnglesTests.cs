using System;
using Angles.Model;
using NUnit.Framework;

namespace Angles.ModelTests
{
    [TestFixture]
    public class ModelTests
    {
        [Test]
        [TestCase(5, 10, 200, 30, 4, 5, 20, true,
            TestName =
                "Тест для метода Validate, когда две плоскости введены корректно")]
        [TestCase(5, 10, 200, 30, 4, 5, 20, false,
            TestName =
                "Тест для метода Validate, когда две плоскости введены некорректно")]
        public void AngleValidatorValidate_Test(double diameter, double distance,
            double height, double length,
            int numberOfHoles, double thickness, double width, bool expectedResult)
        {
            var planeXY = new PlaneParameters(diameter, distance, height, length,
                numberOfHoles, thickness, width);

            PlaneParameters planeZY;

            if (expectedResult)
            {
                planeZY = new PlaneParameters(diameter, distance, height, length,
                    numberOfHoles, thickness, width);

            }
            else
            {
                planeZY = new PlaneParameters(diameter, distance, height, length,
                    numberOfHoles, thickness, width+1);
            }
            

            var result = AngleValidator.ValidateAngle(planeXY, planeZY);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase(PlaneParameters.MaxDiameter + 1, 10, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями диаметра")]
        [TestCase(5, PlaneParameters.MaxRange + 1, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции")]
        [TestCase(5, 10, PlaneParameters.MaxHeight + 1, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями высоты")]
        [TestCase(5, 10, 200, PlaneParameters.MaxRange + 1, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции")]
        [TestCase(5, 10, 200, 30, -1, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями количества отверстий")]
        [TestCase(5, 10, 200, 30, 4, PlaneParameters.MaxThickness + 1, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями толщины")]
        [TestCase(5, 10, 200, 30, 4, 5, PlaneParameters.MaxWidth + 1,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями ширины")]
        [TestCase(PlaneParameters.MinDiameter - 1, 10, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями диаметра")]
        [TestCase(5, PlaneParameters.MinRange - 1, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции")]
        [TestCase(5, 10, PlaneParameters.MinHeight - 1, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями высоты")]
        [TestCase(5, 10, 200, PlaneParameters.MinRange - 1, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции")]
        [TestCase(5, 10, 200, 30, 4, PlaneParameters.MinThickness - 1, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями толщины")]
        [TestCase(5, 10, 200, 30, 4, 5, PlaneParameters.MinWidth - 1,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями ширины")]
        public void PlaneParameterConstructor_NegativeTest
        (double diameter, double distance, double height, double length,
            int numberOfHoles, double thickness, double width)
        {
            Assert.Throws<ArgumentException>(() => new PlaneParameters(diameter, distance,
                height, length,
                numberOfHoles, thickness, width));
        }

        [Test]
        [TestCase(5, 10, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters со значениями по умолчанию")]
        public void PlaneParameterConstructor_PositiveTest
        (double diameter, double distance, double height, double length,
            int numberOfHoles, double thickness, double width)
        {
            var planeParameters = new PlaneParameters(diameter, distance, height, length,
                numberOfHoles, thickness, width);

            Assert.AreEqual(diameter, planeParameters.Diameter);
            Assert.AreEqual(distance, planeParameters.Distance);
            Assert.AreEqual(height, planeParameters.Height);
            Assert.AreEqual(length, planeParameters.Length);
            Assert.AreEqual(numberOfHoles, planeParameters.NumberOfHoles);
            Assert.AreEqual(thickness, planeParameters.Thickness);
            Assert.AreEqual(width, planeParameters.Width);
            Assert.IsInstanceOf<PlaneParameters>(planeParameters);
        }
    }
}