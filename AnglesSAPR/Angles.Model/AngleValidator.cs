namespace Angles.Model
{
    /// <summary>
    ///     Класс для валидации обоих плоскостей уголка и хранящий в себе константы диапазонов значений
    /// </summary>
    public static class AngleValidator
    {
        #region Constants

        /// <summary>
        ///     Максимальное значение высоты
        /// </summary>
        public const double MaxHeight = 200;

        /// <summary>
        ///     Минимальное значение высоты
        /// </summary>
        public const double MinHeight = 50;

        /// <summary>
        ///     Максимальное значение ширины
        /// </summary>
        public const double MaxWidth = 100;

        /// <summary>
        ///     Минимальное значение ширины
        /// </summary>
        public const double MinWidth = 10;

        /// <summary>
        ///     Минимальное значение диаметра
        /// </summary>
        public const double MinDiameter = 5;

        /// <summary>
        ///     Максимальное значение диаметра
        /// </summary>
        public const double MaxDiameter = 20;

        /// <summary>
        ///     Минимальное значение толщины
        /// </summary>
        public const double MinThickness = 3;

        /// <summary>
        ///     Максимальное значение толщины
        /// </summary>
        public const double MaxThickness = 20;

        /// <summary>
        ///     Минимальное значение расстояния
        /// </summary>
        public const double MinRange = 10;

        /// <summary>
        ///     Максимальное значение расстояния
        /// </summary>
        public const double MaxRange = 170;

        #endregion

        #region Public methods

        /// <summary>
        ///     Сравнивает ширину и толщину каждой из плоскостей уголка
        /// </summary>
        /// <param name="planeXOY"></param>
        /// <param name="planeYOZ"></param>
        /// <returns></returns>
        public static bool ValidateAngle(PlaneParameters planeXOY,
            PlaneParameters planeYOZ)
        {
            if (planeXOY == null || planeYOZ == null)
            {
                return false;
            }

            var isPlanesAreCorrect = planeXOY.Width == planeYOZ.Width &&
                                     planeXOY.Thickness == planeYOZ.Thickness;

            return isPlanesAreCorrect;
        }

        #endregion
    }
}