using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourNamespace
{
    public partial class YourForm : Form
    {
        public YourForm()
        {
            InitializeComponent();
        }

        private void CalculateDuplicates(string[] lines)
        {
            // Задача а)
            var duplicatesCount = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                if (duplicatesCount.ContainsKey(line))
                {
                    duplicatesCount[line]++;
                }
                else
                {
                    duplicatesCount[line] = 1;
                }
            }

            // Вивести результати в listBoxRes1
            listBoxRes1.Items.Clear();
            foreach (var pair in duplicatesCount)
            {
                listBoxRes1.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void CalculateStartsWith(string[] lines)
        {
            // Задача б)
            int n = Convert.ToInt32(textBoxN.Text);

            var startsWithCount = new Dictionary<string, int>();

            foreach (var line in lines)
            {
                string prefix = line.Length >= n ? line.Substring(0, n) : line;

                if (startsWithCount.ContainsKey(prefix))
                {
                    startsWithCount[prefix]++;
                }
                else
                {
                    startsWithCount[prefix] = 1;
                }
            }

            // Вивести результати в listBoxRes2
            listBoxRes2.Items.Clear();
            foreach (var pair in startsWithCount)
            {
                listBoxRes2.Items.Add($"{pair.Key}: {pair.Value}");
            }
        }

        private void ButtonCalculate_Click_1(object sender, EventArgs e)
        {
            // Отримати рядки з MyRichTextBox
            string[] lines = MyrichTextBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Виконати обрахунки
            CalculateDuplicates(lines);
            CalculateStartsWith(lines);

        }
    }
}
