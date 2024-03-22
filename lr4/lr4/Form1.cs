using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_len_minus_Click(object sender, EventArgs e)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int negativeCount = 0;

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeCount++;
                }
            }

            listBoxResult.Items.Clear();
            listBoxResult.Items.Add($"Кількість від'ємних елементів у масиві: {negativeCount}");
        }




        private void button_sum_Click(object sender, EventArgs e)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // Знаходимо мінімальний за модулем елемент масиву
            double minAbsoluteValue = Math.Abs(numbers[0]);
            int minIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                double absValue = Math.Abs(numbers[i]);
                if (absValue < minAbsoluteValue)
                {
                    minAbsoluteValue = absValue;
                    minIndex = i;
                }
            }

            // Обчислюємо суму модулів елементів після мінімального за модулем елемента
            double sumOfAbsoluteValues = 0;
            for (int i = minIndex + 1; i < numbers.Length; i++)
            {
                sumOfAbsoluteValues += Math.Abs(numbers[i]);
            }

            // Виводимо результат у listBoxResult
            listBoxResult.Items.Clear();
            listBoxResult.Items.Add($"Сума модулів елементів після мінімального за модулем елемента: {sumOfAbsoluteValues}");
        }

        private void button_all_pluss_Click(object sender, EventArgs e)
        {

            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            // Заміна від'ємних елементів на їх квадрати
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = numbers[i] * numbers[i];
                }
            }

            // Сортування елементів за зростанням
            Array.Sort(numbers);

            // Очищення вмісту listBoxResult
            listBoxResult.Items.Clear();

            listBoxResult.Items.Add("Елементи масиву після заміни від'ємних на їх квадрати та сортування за зростанням:");
            foreach (int num in numbers)
            {
                listBoxResult.Items.Add(num);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Даний двовимірний масив
            int[,] twoDimensionalArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            // Очищення вмісту listBoxResult_2
            listBoxResult_2.Items.Clear();

            // Виведення двовимірного масиву у listBoxResult_2
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    row += twoDimensionalArray[i, j] + "\t";
                }
                listBoxResult_2.Items.Add(row);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Даний двовимірний масив
            int[,] twoDimensionalArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
            };

            // Отримання розміру масиву
            int rows = twoDimensionalArray.GetLength(0);
            int cols = twoDimensionalArray.GetLength(1);

            // Обмін елементів
            int temp = twoDimensionalArray[0, cols - 1];
            twoDimensionalArray[0, cols - 1] = twoDimensionalArray[rows - 1, 0];
            twoDimensionalArray[rows - 1, 0] = temp;

            // Виведення результату у listBoxResult_2
            listBoxResult_2.Items.Clear();
            for (int i = 0; i < rows; i++)
            {
                string row = "";
                for (int j = 0; j < cols; j++)
                {
                    row += twoDimensionalArray[i, j] + " ";
                }
                listBoxResult_2.Items.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Даний двовимірний масив
            int[,] twoDimensionalArray = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

            // Отримання розміру масиву
            int rows = twoDimensionalArray.GetLength(0);
            int cols = twoDimensionalArray.GetLength(1);

            // Знаходимо нижній правий елемент і верхній лівий елемент
            int lowerRightElement = twoDimensionalArray[rows - 1, cols - 1];
            int upperLeftElement = twoDimensionalArray[0, 0];

            // Обмін значень між нижнім правим та верхнім лівим елементами
            twoDimensionalArray[rows - 1, cols - 1] = upperLeftElement;
            twoDimensionalArray[0, 0] = lowerRightElement;

            // Очищення вмісту listBoxResult_2
            listBoxResult_2.Items.Clear();

            // Виведення результату у listBoxResult_2
            for (int i = 0; i < rows; i++)
            {
                string row = "";
                for (int j = 0; j < cols; j++)
                {
                    row += twoDimensionalArray[i, j] + "\t";
                }
                listBoxResult_2.Items.Add(row);
            }
        }

    }
}
