namespace lr2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Result_listBox = new System.Windows.Forms.ListBox();
            this.x_inp = new System.Windows.Forms.TextBox();
            this.coef_inp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Result_listBox
            // 
            this.Result_listBox.FormattingEnabled = true;
            this.Result_listBox.Location = new System.Drawing.Point(58, 175);
            this.Result_listBox.Name = "Result_listBox";
            this.Result_listBox.Size = new System.Drawing.Size(226, 108);
            this.Result_listBox.TabIndex = 4;
            // 
            // x_inp
            // 
            this.x_inp.Location = new System.Drawing.Point(58, 97);
            this.x_inp.Name = "x_inp";
            this.x_inp.Size = new System.Drawing.Size(135, 20);
            this.x_inp.TabIndex = 5;
            // 
            // coef_inp
            // 
            this.coef_inp.Location = new System.Drawing.Point(58, 123);
            this.coef_inp.Name = "coef_inp";
            this.coef_inp.Size = new System.Drawing.Size(135, 20);
            this.coef_inp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coef_inp);
            this.Controls.Add(this.x_inp);
            this.Controls.Add(this.Result_listBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Result_listBox;
        private System.Windows.Forms.TextBox x_inp;
        private System.Windows.Forms.TextBox coef_inp;
    }
}

