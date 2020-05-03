using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Angles.KompasWrapper;
using Angles.Model;
using static Angles.View.FormTools;

namespace Angles.View
{
    public partial class MainForm : Form
    {
        #region Readonly fields

        private readonly Builder _builder = new Builder();

        #endregion

        #region Private fields

        /// <summary>
        ///     Плоскость #1
        /// </summary>
        private PlaneParameters _planeXOY;

        /// <summary>
        ///     Плоскость #2
        /// </summary>
        private PlaneParameters _planeYOZ;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Обработчик события нажатия на кнопку построить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buildButton_Click(object sender, EventArgs e)
        {
            if (AngleValidator.ValidateAngle(_planeXOY, _planeYOZ))
            {
                _builder.StartKompas();
                _builder.Build(_planeXOY, _planeYOZ);
            }
            else
            {
                MessageBox.Show(
                    "Сначала введите корректно параметры обоих плоскостей!\nШирина и толщина каждой плоскости обязательно должны быть равны!");
            }
        }

        /// <summary>
        ///     Обработчик события валидации TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                TextBoxCheck(textBox, e);
            }
        }

        ///// <summary>
        /////     Обработчик события изменения текста в TextBox
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "")
                {
                }
                else
                {
                    try
                    {
                        textBox.ForeColor = Color.Black;
                        Convert.ToDouble(textBox.Text);
                    }
                    catch (FormatException exception)
                    {
                        MessageBox.Show(
                            "Вы вводите некорректные символы!\nДопускаются только цифры и разделители: . и ,\n" +
                            " Удалите последний введёный символ и продолжите ввод\n");
                    }
                }
            }
        }

        /// <summary>
        ///     Обработчик события изменения текста в numberOfHolesTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberOfHolesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (numberOfHolesTextBox.Text == "")
            {
            }
            else
            {
                try
                {
                    Convert.ToInt32(numberOfHolesTextBox.Text);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("Вы вводите некорректные символы!\n" +
                                    exception.Message);
                }
            }
        }

        /// <summary>
        ///     Обработчик события нажатия на кнопку сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savePlaneButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstPlaneRadioButton.Checked)
                {
                    _planeXOY = new PlaneParameters(
                        Convert.ToDouble(diameterTextBox.Text),
                        Convert.ToDouble(distanceTextBox.Text),
                        Convert.ToDouble(heightTextBox.Text),
                        Convert.ToDouble(lengthTextBox.Text),
                        Convert.ToInt32(numberOfHolesTextBox.Text),
                        Convert.ToDouble(thicknessTextBox.Text),
                        Convert.ToDouble(widthTextBox.Text));
                }
                else
                {
                    _planeYOZ = new PlaneParameters(
                        Convert.ToDouble(diameterTextBox.Text),
                        Convert.ToDouble(distanceTextBox.Text),
                        Convert.ToDouble(heightTextBox.Text),
                        Convert.ToDouble(lengthTextBox.Text),
                        Convert.ToInt32(numberOfHolesTextBox.Text),
                        Convert.ToDouble(thicknessTextBox.Text),
                        Convert.ToDouble(widthTextBox.Text));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.Message);
            }

            if (_planeXOY != null && _planeYOZ != null)
            {
                if (!AngleValidator.ValidateAngle(_planeXOY, _planeYOZ))
                {
                    MessageBox.Show(
                        "Ширина и толщина каждой плоскости обязательно должны быть равны!");
                }
            }
        }

        private void secondPlaneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (secondPlaneRadioButton.Checked)
            {
                if (_planeXOY == null)
                {
                    secondPlaneRadioButton.Checked = false;
                    firstPlaneRadioButton.Checked = true;
                    MessageBox.Show("Сначала заполните первую плоскость!");
                }
            }
        }

        #endregion
    }
}