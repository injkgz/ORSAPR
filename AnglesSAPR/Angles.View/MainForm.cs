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

        private AngleParameters parameters;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void buildButton_Click(object sender, EventArgs e)
        {
            var isCorrectParameters = true;
            try
            {
                isCorrectParameters = true;
                parameters = new AngleParameters(Convert.ToDouble(diameterTextBox.Text),
                    Convert.ToDouble(distanceTextBox.Text),
                    Convert.ToDouble(heightTextBox.Text),
                    Convert.ToDouble(lengthTextBox.Text),
                    Convert.ToInt32(numberOfHolesTextBox.Text),
                    Convert.ToDouble(thicknessTextBox.Text),
                    Convert.ToDouble(widthTextBox.Text));
            }
            catch (ArgumentException exception)
            {
                isCorrectParameters = false;
                MessageBox.Show(
                    exception.Message);
            }

            if (isCorrectParameters)
            {
                _builder.StartKompas();
                _builder.Build(parameters);
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

        #endregion
    }
}