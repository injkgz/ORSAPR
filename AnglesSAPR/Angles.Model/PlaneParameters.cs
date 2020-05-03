using System;

namespace Angles.Model
{
    /// <summary>
    ///     Параметры уголка
    /// </summary>
    public class PlaneParameters
    {
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
            private set
            {
                if (value < AngleValidator.MinDiameter ||
                    value > AngleValidator.MaxDiameter)
                {
                    throw new ArgumentException("Диаметр должен быть в пределах от " +
                                                AngleValidator.MinDiameter + " до " +
                                                AngleValidator.MaxDiameter + "!");
                }

                _diameter = value;
            }
        }

        /// <summary>
        ///     Расстояние от крайней грани до центра первого отверстия L
        /// </summary>
        public double Distance
        {
            get => _distance;
            set
            {
                if (value < AngleValidator.MinRange || value > AngleValidator.MaxRange)
                {
                    throw new ArgumentException("Расстояние должно быть в пределах от " +
                                                AngleValidator.MinRange + " до " +
                                                AngleValidator.MaxRange + "!");
                }

                _distance = value;
            }
        }

        /// <summary>
        ///     Высота уголка
        /// </summary>
        public double Height
        {
            get => _height;
            private set
            {
                if (value < AngleValidator.MinHeight || value > AngleValidator.MaxHeight)
                {
                    throw new ArgumentException("Высота должна быть в пределах от " +
                                                AngleValidator.MinHeight + " до " +
                                                AngleValidator.MaxHeight + "!");
                }

                _height = value;
            }
        }

        /// <summary>
        ///     Расстояние от грани, прилежащей к другой плоскости, до центра ближайшего отверстия
        /// </summary>
        public double Length
        {
            get => _length;
            private set
            {
                if (value < AngleValidator.MinRange || value > AngleValidator.MaxRange)
                {
                    throw new ArgumentException("Расстояние должно быть в пределах от " +
                                                AngleValidator.MinRange + " до " +
                                                AngleValidator.MaxRange + "!");
                }

                _length = value;
            }
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
            private set
            {
                if (value < AngleValidator.MinThickness ||
                    value > AngleValidator.MaxThickness)
                {
                    throw new ArgumentException("Толщина должна быть в пределах от " +
                                                AngleValidator.MinThickness + " до " +
                                                AngleValidator.MaxThickness + "!");
                }

                _thickness = value;
            }
        }

        /// <summary>
        ///     Ширина уголка
        /// </summary>
        public double Width
        {
            get => _width;
            private set
            {
                if (value < AngleValidator.MinWidth || value > AngleValidator.MaxWidth)
                {
                    throw new ArgumentException("Ширина должна быть в пределах от " +
                                                AngleValidator.MinWidth + " до " +
                                                AngleValidator.MaxWidth + "!");
                }

                _width = value;
            }
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

            if (width / 2 <= diameter)
            {
                throw new ArgumentException(
                    "Диаметр не может быть больше ширины уголка или равен ей");
            }

            if (height / 2 <= diameter)
            {
                throw new ArgumentException(
                    "Диаметр не может быть больше ширины уголка или равен ей");
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
    }
}