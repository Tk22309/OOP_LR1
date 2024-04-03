namespace YourNamespace
{
    partial class YourForm
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
            this.MyrichTextBox = new System.Windows.Forms.RichTextBox();
            this.listBoxRes1 = new System.Windows.Forms.ListBox();
            this.listBoxRes2 = new System.Windows.Forms.ListBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MyrichTextBox
            // 
            this.MyrichTextBox.Location = new System.Drawing.Point(63, 30);
            this.MyrichTextBox.Name = "MyrichTextBox";
            this.MyrichTextBox.Size = new System.Drawing.Size(190, 134);
            this.MyrichTextBox.TabIndex = 0;
            this.MyrichTextBox.Text = "";
            // 
            // listBoxRes1
            // 
            this.listBoxRes1.FormattingEnabled = true;
            this.listBoxRes1.Location = new System.Drawing.Point(398, 41);
            this.listBoxRes1.Name = "listBoxRes1";
            this.listBoxRes1.Size = new System.Drawing.Size(268, 134);
            this.listBoxRes1.TabIndex = 1;
            // 
            // listBoxRes2
            // 
            this.listBoxRes2.FormattingEnabled = true;
            this.listBoxRes2.Location = new System.Drawing.Point(398, 201);
            this.listBoxRes2.Name = "listBoxRes2";
            this.listBoxRes2.Size = new System.Drawing.Size(268, 134);
            this.listBoxRes2.TabIndex = 2;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(63, 208);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(160, 47);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click_1);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(62, 282);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(160, 20);
            this.textBoxN.TabIndex = 4;
            // 
            // YourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.listBoxRes2);
            this.Controls.Add(this.listBoxRes1);
            this.Controls.Add(this.MyrichTextBox);
            this.Name = "YourForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MyrichTextBox;
        private System.Windows.Forms.ListBox listBoxRes1;
        private System.Windows.Forms.ListBox listBoxRes2;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox textBoxN;
    }
}

