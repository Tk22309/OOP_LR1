using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void x_inp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }
        private void coef_inp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Відміна введення символів, які не є цифрами
            }
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            // Отримання значень з текстових полів
            double x = Convert.ToDouble(x_inp.Text);
            char sign = coef_inp.Text[0]; // Припускаємо, що введений лише один символ (+ або -)

            // Створення екземпляра класу Equation і виклик методу Solve
            Equation equation = new Equation(x, sign);
            string result = equation.Solve();

            // Відображення результату у Result_listBox
            Result_listBox.Items.Clear();
            Result_listBox.Items.Add(result);
        }
    }
}
