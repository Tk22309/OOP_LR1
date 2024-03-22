namespace lr4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.button_sum = new System.Windows.Forms.Button();
            this.button_all_pluss = new System.Windows.Forms.Button();
            this.button_len_minus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxResult_2 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(32, 122);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(466, 251);
            this.listBoxResult.TabIndex = 0;
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(151, 74);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(98, 42);
            this.button_sum.TabIndex = 2;
            this.button_sum.Text = "суму модулів елементів масиву";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // button_all_pluss
            // 
            this.button_all_pluss.Location = new System.Drawing.Point(270, 64);
            this.button_all_pluss.Name = "button_all_pluss";
            this.button_all_pluss.Size = new System.Drawing.Size(124, 52);
            this.button_all_pluss.TabIndex = 3;
            this.button_all_pluss.Text = "Замінити всі від’ємні елементи масиву їх квадратами";
            this.button_all_pluss.UseVisualStyleBackColor = true;
            this.button_all_pluss.Click += new System.EventHandler(this.button_all_pluss_Click);
            // 
            // button_len_minus
            // 
            this.button_len_minus.Location = new System.Drawing.Point(32, 74);
            this.button_len_minus.Name = "button_len_minus";
            this.button_len_minus.Size = new System.Drawing.Size(98, 42);
            this.button_len_minus.TabIndex = 4;
            this.button_len_minus.Text = "суму модулів елементів масиву";
            this.button_len_minus.UseVisualStyleBackColor = true;
            this.button_len_minus.Click += new System.EventHandler(this.button_len_minus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Масив  : { -4, -3, -2, -1, 0, 1, 2, 3, 4 }";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Завдання 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Завдання 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 97);
            this.button1.TabIndex = 8;
            this.button1.Text = "Поміняти місцями елементи, розміщені у верхньому правому і нижньому лівому кутах";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 97);
            this.button2.TabIndex = 9;
            this.button2.Text = "поміняти місцями розміщені у нижньому правому і верхньому лівому кутах";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 97);
            this.button3.TabIndex = 10;
            this.button3.Text = "вивести масив";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxResult_2
            // 
            this.listBoxResult_2.FormattingEnabled = true;
            this.listBoxResult_2.Location = new System.Drawing.Point(101, 158);
            this.listBoxResult_2.Name = "listBoxResult_2";
            this.listBoxResult_2.Size = new System.Drawing.Size(347, 160);
            this.listBoxResult_2.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 517);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxResult);
            this.tabPage1.Controls.Add(this.button_len_minus);
            this.tabPage1.Controls.Add(this.button_sum);
            this.tabPage1.Controls.Add(this.button_all_pluss);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxResult_2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Завдання 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Киричеко Даниїл 203тк 9 варінант";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_all_pluss;
        private System.Windows.Forms.Button button_len_minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxResult_2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
    }
}

