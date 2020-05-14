using System;
using Angles.Model;
using NUnit.Framework;

namespace Angles.ModelTests
{
    [TestFixture]
    public class ModelTests
    {
        [Test]
        [TestCase(300, 10, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями диаметра 1 ")]
        [TestCase(5, 171, 200, 30, 1, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции 1")]
        [TestCase(5, 10, 201, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями высоты 1")]
        [TestCase(5, 10, 200, 171, 1, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции 1")]
        [TestCase(5, 10, 200, 30, -1, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями количества отверстий 1")]
        [TestCase(5, 10, 200, 30, 4, 21, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями толщины 1")]
        [TestCase(5, 10, 200, 30, 4, 5, 101,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями ширины 1")]
        [TestCase(4, 10, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями диаметра 2")]
        [TestCase(5, 9, 200, 30, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции 2")]
        [TestCase(5, 10, 49, 30, 1, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями высоты 2")]
        [TestCase(5, 10, 200, 9, 4, 5, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями дистанции 2")]
        [TestCase(5, 10, 200, 30, 4, 2, 20,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями толщины 2")]
        [TestCase(5, 10, 200, 30, 4, 5, 9,
            TestName =
                "Тест на создание объекта PlaneParameters с некорректными значениями ширины 2")]
        public void PlaneParameterConstructor_NegativeTest
        (double diameter, double distance, double height, double length,
            int numberOfHoles, double thickness, double width)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new PlaneParameters(diameter, distance,
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