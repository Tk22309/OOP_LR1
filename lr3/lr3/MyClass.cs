using System;
using System.Windows.Forms;

namespace lr3
{
    class MyClass
    {
        // Метод для обчислення Z та виведення результату в Result_Label
        public static void CalculateAndDisplayResult(TextBox textBox_X, TextBox textBox_Z1, TextBox textBox_Z2, Label Result_Label)
        {
            // Отримання значень з текстових полів
            double X;
            double Z1;
            double Z2;

            if (double.TryParse(textBox_X.Text, out X) && double.TryParse(textBox_Z1.Text, out Z1) && double.TryParse(textBox_Z2.Text, out Z2))
            {
                // Обчислення значення Z
                double Z_1 = Z1 + Z2 * X;
                double Z_2 = Z1 - Z2 * X;
                double Z_3 = Z1 * Z2 * X;
                double Z_4 = Z1 / Z2 * X;

                // Форматування та виведення результатів
                string resultText = $"{Z1} + {Z2} * X\n{Z_1}\n{Z1} - {Z2} * X\n{Z_2}\n{Z1} * {Z2} * X\n{Z_3}\n{Z1} / {Z2} * X\n{Z_4}\n";
                Result_Label.Text = resultText;
            }
            else
            {
                // Обробка помилок при введенні неправильних значень
                Result_Label.Text = "Некоректні дані";
            }
        }
    }
}
