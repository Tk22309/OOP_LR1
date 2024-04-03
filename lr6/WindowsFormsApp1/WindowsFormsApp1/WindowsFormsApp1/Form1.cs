using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функція для розподілу комплексних чисел
        private ComplexNumber DivideComplexNumbers(ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber result;

            double denominator = B.RealPart * B.RealPart + B.ImaginaryPart * B.ImaginaryPart;
            result.RealPart = (A.RealPart * B.RealPart + A.ImaginaryPart * B.ImaginaryPart) / denominator;
            result.ImaginaryPart = (A.ImaginaryPart * B.RealPart - A.RealPart * B.ImaginaryPart) / denominator;

            return result;
        }

        // Структура для представлення комплексного числа
        struct ComplexNumber
        {
            public double RealPart; // Реальна частина
            public double ImaginaryPart; // Уявна частина
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка коректності введених даних
            double realPartA, imaginaryPartA, realPartB, imaginaryPartB;
            if (!double.TryParse(textBox1.Text, out realPartA) || !double.TryParse(textBox2.Text, out imaginaryPartA) ||
                !double.TryParse(textBox3.Text, out realPartB) || !double.TryParse(textBox4.Text, out imaginaryPartB))
            {
                MessageBox.Show("Будь ласка, введіть коректні числа для обох комплексних чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обчислення розподілу комплексних чисел
            ComplexNumber A, B;
            A.RealPart = realPartA;
            A.ImaginaryPart = imaginaryPartA;
            B.RealPart = realPartB;
            B.ImaginaryPart = imaginaryPartB;

            ComplexNumber result = DivideComplexNumbers(A, B);

            // Відображення результату на мітці
            label5.Text = string.Format("Результат розподілу: {0} + {1}i", result.RealPart, result.ImaginaryPart);
        }
    }
}
