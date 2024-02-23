using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn.Click += CalculateResult;
        }
// Ex1
        // Обробник подій для введення символів у текстовому полі txtX.
        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        // Обробник подій для кнопки, яка викликається при натисканні.
        private void CalculateResult(object sender, EventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x))
            {
                // Рахуємо вираз
                double result = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(Math.Abs(1 + x * x));

                // Виводимо результат у лейбл
                Result.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введіть коректне значення для X"); // Виведення повідомлення про помилку, якщо введено некоректне значення
            }
        }

        //Ex2
        // Обробник подій для введення символів у текстовому полі textBox3.
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        // Обробник подій для введення символів у текстовому полі textBox2.
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }
        // Обробник подій для введення символів у текстовому полі textBox1.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        // Обробник подій для кнопки, яка викликається при натисканні.
        private void btn2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b) &&
                double.TryParse(textBox1.Text, out double gammaDegrees))
            {
                // Конвертуємо кут з градусів в радіани
                double gammaRadians = Math.PI * gammaDegrees / 180.0;

                // Знаходимо площу трикутника
                double area = 0.5 * a * b * Math.Sin(gammaRadians);

                // Виводимо результат у лейбл
                label6.Text = "Площа трикутника: " + area.ToString();
            }
            else
            {
                MessageBox.Show("Введіть коректні значення для a, b та кута γ"); // Виведення повідомлення про помилку, якщо введено некоректні значення
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        //Ex3
        // Обробник подій для введення значень у textBox4. Забороняє введення нецифрових символів.
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        // Аналогічно для textBox5, textBox6 і textBox7

        // Обробник подій для кнопки btn1, яка викликається при натисканні.
        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання значень з текстових полів та конвертація їх у числа.
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Convert.ToDouble(textBox6.Text);
            double d = Convert.ToDouble(textBox7.Text);

            // Виклик функції для порівняння та виведення результату у label12.
            bool areSimilar = AreTrianglesSimilar(a, b, c, d);
            label12.Text = "Трикутники подібні: " + areSimilar.ToString();
        }

        // Статична функція для перевірки подібності трикутників з заданими сторонами.
        static bool AreTrianglesSimilar(double a, double b, double c, double d)
        {
            return (a / c == b / d) || (a / d == b / c);
        }



        //Ex4
        // Обробник подій для введення значень у textBox8. Забороняє введення нецифрових символів.
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        // Аналогічно для textBox9 та textBox10

        // Обробник подій для кнопки button2, яка викликається при натисканні.
        private void button2_Click(object sender, EventArgs e)
        {
            // Отримання значень з текстових полів та конвертація їх у числа.
            double a = Convert.ToDouble(textBox8.Text);
            double b = Convert.ToDouble(textBox9.Text);
            double c = Convert.ToDouble(textBox10.Text);

            // Перевірка умов для існування трикутника та виведення результату у відповідні label-и.
            bool ab = a + b > 0;
            bool bc = b + c > 0;
            bool ac = a + c > 0;

            label16.Text = "a + b: " + ab.ToString(); // Виведення результату у label16
            label17.Text = "b + c: " + bc.ToString(); // Виведення результату у label17
            label18.Text = "a + c: " + ac.ToString(); // Виведення результату у label18
        }

        //Ex5
        // Обробник подій для кнопки btn5_1, яка викликається при натисканні.
        private void btn5_1_Click(object sender, EventArgs e)
        {
            // Виклик функції для знаходження віку довгожителя.
            int age = FindLongevityAge();

            // Виведення результату у lblResult5_1 з використанням рядка з форматуванням.
            lblResult5_1.Text = $"Довгожитель має вік: {age} років";
        }

        // Функція для знаходження віку довгожителя.
        private int FindLongevityAge()
        {
            // Цикл для перебору віку від 100 до 999.
            for (int age = 100; age < 1000; age++)
            {
                // Виклик функції для обчислення суми квадратів цифр віку.
                int sumOfDigitsSquared = CalculateSumOfDigitsSquared(age);

                // Перевірка умови для знаходження віку довгожителя.
                if (sumOfDigitsSquared + age == age)
                {
                    return age; // Повернення віку, якщо умова виконана.
                }
            }

            // Якщо жодного віку не знайдено, повернути -1 або інше спеціальне значення.
            return -1;
        }

        // Функція для обчислення суми квадратів цифр числа.
        private int CalculateSumOfDigitsSquared(int number)
        {
            int sum = 0;

            // Цикл для обчислення суми квадратів цифр числа.
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }

            // Повернення суми квадратів цифр числа.
            return sum;
        }

        //Ex6
        // Обробник подій для кнопки btn6_1, яка викликається при натисканні.
        private void btn6_1_Click(object sender, EventArgs e)
        {
            // Визначення початкових масивів a і b.
            int[] a = { -2, -1, 0, 1, 2 };
            int[] b = { 0, 1, 2, 3, 4 };

            // Виклик функції для трансформації масивів a і b.
            int[] transformedArray = TransformSequences(a, b);

            // Форматування результуючого масиву у рядок та виведення у Lbl_6_1.
            string arrayAsString = string.Join(", ", transformedArray);
            Lbl_6_1.Text = arrayAsString;
        }

        // Функція для трансформації масивів a та b за заданим правилом.
        private int[] TransformSequences(int[] a, int[] b)
        {
            // Визначення результуючого масиву довжиною менше або рівно мінімальній довжині масивів a і b.
            int[] resultArray = new int[Math.Min(a.Length, b.Length)];

            // Цикл для проходження крізь елементи масивів a та b та їх трансформації.
            for (int i = 0; i < resultArray.Length; i++)
            {
                // Якщо елемент a менше або рівно нулю, тоді множимо відповідний елемент b на 10.
                // В іншому випадку присвоюємо нуль.
                if (a[i] <= 0)
                {
                    resultArray[i] = b[i] * 10;
                }
                else
                {
                    resultArray[i] = 0;
                }
            }

            // Повернення трансформованого масиву.
            return resultArray;
        }

        //Ex7
        // Обробник подій для кнопки btn_7, яка викликається при натисканні.
        private void btn_7_Click(object sender, EventArgs e)
        {
            // Отримання текстового рядка з Text_7.
            string text = Text_7.Text;

            // Виклик функції для підрахунку кількості входжень кожного символа.
            int countA = CountOccurrences(text, 'a');
            int countB = CountOccurrences(text, 'b');
            int countC = CountOccurrences(text, 'c');

            // Форматування результату та виведення у Lbl_7.
            Lbl_7.Text = $"Кількість 'a' : {countA}\nКількість 'b' : {countB}\nКількість 'c' : {countC}";
        }

        // Функція для підрахунку кількості входжень символа у текстовий рядок.
        private int CountOccurrences(string input, char character)
        {
            int count = 0;

            // Цикл для перебору кожного символа в текстовому рядку.
            foreach (char c in input)
            {
                // Підрахунок кількості входжень символа у текстовий рядок.
                if (c == character)
                {
                    count++;
                }
            }

            // Повернення кількості входжень символа у текстовий рядок.
            return count;
        }




    }
}
