using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
           // Виклик методу з класу MyClass для обчислення та виведення результату
            MyClass.CalculateAndDisplayResult(textBox_X, textBox_Z1, textBox_Z2, Result_Label);
        }
    }
}
