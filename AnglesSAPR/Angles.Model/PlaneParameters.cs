using System;

namespace Angles.Model
{
    /// <summary>
    ///     Параметры уголка
    /// </summary>
    public class PlaneParameters
    {
        #region Constants

        /// <summary>
        ///     Максимальное значение высоты
        /// </summary>
        private const double MaxHeight = 200;

        /// <summary>
        ///     Минимальное значение высоты
        /// </summary>
        private const double MinHeight = 50;

        /// <summary>
        ///     Максимальное значение ширины
        /// </summary>
        private const double MaxWidth = 100;

        /// <summary>
        ///     Минимальное значение ширины
        /// </summary>
        private const double MinWidth = 10;

        /// <summary>
        ///     Минимальное значение диаметра
        /// </summary>
        private const double MinDiameter = 5;

        /// <summary>
        ///     Максимальное значение диаметра
        /// </summary>
        private const double MaxDiameter = 20;

        /// <summary>
        ///     Минимальное значение толщины
        /// </summary>
        private const double MinThickness = 3;

        /// <summary>
        ///     Максимальное значение толщины
        /// </summary>
        private const double MaxThickness = 20;

        /// <summary>
        ///     Минимальное значение расстояния
        /// </summary>
        private const double MinRange = 10;

        /// <summary>
        ///     Максимальное значение расстояния
        /// </summary>
        private const double MaxRange = 170;

        #endregion

        #region Private fields

        /// <summary>
        ///     Диаметр уголка
        /// </summary>
        private double _diameter;

        /// <summary>
        ///     Расстояние от крайней грани до центра первого отверстия
        /// </summary>
        private double _distance;

        /// <summary>
        ///     Дистанция между отверстиями
        /// </summary>
        private double _distanceBetweenHoles;

        /// <summary>
        ///     Высота уголка
        /// </summary>
        private double _height;

        /// <summary>
        ///     Расстояние от грани, прилежащей к другой плоскости, до центра ближайшего отверстия
        /// </summary>
        private double _length;

        /// <summary>
        ///     Количество отверстий на каждой плоскости
        /// </summary>
        private int _numberOfHoles;

        /// <summary>
        ///     Толщина уголка
        /// </summary>
        private double _thickness;

        /// <summary>
        ///     Ширина уголка
        /// </summary>
        private double _width;

        #endregion

        #region Properties

        /// <summary>
        ///     Дистанция между отверстиями
        /// </summary>
        public double DistanceBetweenHoles
        {
            get => _distanceBetweenHoles;
            private set => _distanceBetweenHoles = value;
        }

        /// <summary>
        ///     Диаметр уголка
        /// </summary>
        public double Diameter
        {
            get => _diameter;
            private set => _diameter = SetCorrectValue(ParameterType.Diameter, value,
                MaxDiameter, MaxDiameter);
        }

        /// <summary>
        ///     Расстояние от крайней грани до центра первого отверстия L
        /// </summary>
        public double Distance
        {
            get => _distance;
            set => _distance =
                SetCorrectValue(ParameterType.Range, value, MaxRange, MinRange);
        }

        /// <summary>
        ///     Высота уголка
        /// </summary>
        public double Height
        {
            get => _height;
            private set => _height =
                SetCorrectValue(ParameterType.Height, value, MaxHeight, MinHeight);
        }

        /// <summary>
        ///     Расстояние от грани, прилежащей к другой плоскости, до центра ближайшего отверстия
        /// </summary>
        public double Length
        {
            get => _length;
            private set => _length =
                SetCorrectValue(ParameterType.Range, value, MaxRange, MinRange);
        }

        /// <summary>
        ///     Количество отверстий на каждой плоскости
        /// </summary>
        public int NumberOfHoles
        {
            get => _numberOfHoles;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Количество отверстий не может быть отрицательным или равно 0!");
                }

                _numberOfHoles = value;
            }
        }

        /// <summary>
        ///     Толщина уголка
        /// </summary>
        public double Thickness
        {
            get => _thickness;
            private set => _thickness = SetCorrectValue(ParameterType.Thickness, value,
                MaxThickness, MinThickness);
        }

        /// <summary>
        ///     Ширина уголка
        /// </summary>
        public double Width
        {
            get => _width;
            private set => _width =
                SetCorrectValue(ParameterType.Width, value, MaxWidth, MinWidth);
        }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор параметров уголка
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="distance"></param>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="numberOfHoles"></param>
        /// <param name="thickness"></param>
        /// <param name="width"></param>
        public PlaneParameters(double diameter, double distance, double height,
            double length, int numberOfHoles, double thickness, double width)
        {
            var calculatedNumberOfHoles =
                Convert.ToInt32(
                    Math.Truncate((height - length - distance) / (diameter + 5)));

            if (numberOfHoles == 1)
            {
                if (distance + diameter / 2 > height)
                {
                    throw new ArgumentException(
                        "Отверстие будет расположено некорректно, пожалуйста введите другую комбинацию другие расстояния от граней!");
                }
            }
            else
            {
                if (numberOfHoles > calculatedNumberOfHoles)
                {
                    throw new ArgumentException(
                        "Неправильно введено количество отверстий!\nВажно помнить, что расстояния от граней и количество отверстий тесно связаны между собой!" +
                        "\nПожалуйста убедитесь, что подобный металлический уголок возможен!");
                }
            }

            if (width / 2 <= diameter || height / 2 <= diameter)
            {
                throw new ArgumentException(
                    "Диаметр не может быть больше ширины/длины уголка или равен ей");
            }


            Diameter = diameter;
            Distance = distance;
            Height = height;
            Length = length;
            NumberOfHoles = numberOfHoles;
            Thickness = thickness;
            Width = width;
            DistanceBetweenHoles =
                (Height - Distance -
                 Length) / (NumberOfHoles - 1);
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Установка корректных значений параметра
        /// </summary>
        /// <param name="parameterType">Тип параметра</param>
        /// <param name="value">Проверяемое значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="minValue">Минимальное значение</param>
        /// <returns></returns>
        private double SetCorrectValue(ParameterType parameterType, double value,
            double maxValue,
            double minValue)
        {
            if (value > maxValue ||
                value < minValue)
            {
                throw new ArgumentOutOfRangeException(
                    "Значение : " + value +
                    " не входит в диапазон допустимых значений для параметра " +
                    parameterType);
            }

            return value;
        }

        #endregion
    }
}