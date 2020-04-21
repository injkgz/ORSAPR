using System;

namespace Angles.Model
{
    /// <summary>
    ///     Параметры уголка
    /// </summary>
    public class AngleParameters
    {
        #region Private fields

        /// <summary>
        ///     Диаметр уголка
        /// </summary>
        private double _diameter;

        /// <summary>
        ///     Расстояние от крайней грани до центра первого отверстия L
        /// </summary>
        private double _distance;

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
        private double _numberOfHoles;

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
        ///     Диаметр уголка
        /// </summary>
        public double Diameter
        {
            get => _diameter;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
                }

                _length = value;
            }
        }

        /// <summary>
        ///     Количество отверстий на каждой плоскости
        /// </summary>
        public double NumberOfHoles
        {
            get => _numberOfHoles;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Значение не может быть отрицательным!");
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
        public AngleParameters(double diameter, double distance, double height,
            double length, double numberOfHoles, double thickness, double width)
        {
            Diameter = diameter;
            Distance = distance;
            Height = height;
            Length = length;
            NumberOfHoles = numberOfHoles;
            Thickness = thickness;
            Width = width;
        }

        #endregion
    }
}