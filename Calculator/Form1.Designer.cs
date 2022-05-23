
namespace Calculator
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxOperand2 = new System.Windows.Forms.TextBox();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.textBoxOperand1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(37, 125);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(141, 20);
            this.textBoxResult.TabIndex = 7;
            // 
            // textBoxOperand2
            // 
            this.textBoxOperand2.Location = new System.Drawing.Point(37, 86);
            this.textBoxOperand2.Name = "textBoxOperand2";
            this.textBoxOperand2.Size = new System.Drawing.Size(141, 20);
            this.textBoxOperand2.TabIndex = 2;
            // 
            // division
            // 
            this.division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.division.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.division.Location = new System.Drawing.Point(263, 92);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(64, 53);
            this.division.TabIndex = 6;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.multiplication.Location = new System.Drawing.Point(196, 92);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(61, 53);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.subtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtraction.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.subtraction.Location = new System.Drawing.Point(263, 31);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(64, 52);
            this.subtraction.TabIndex = 4;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addition.Location = new System.Drawing.Point(196, 31);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(61, 52);
            this.addition.TabIndex = 3;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(37, 152);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(290, 31);
            this.Close.TabIndex = 8;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // textBoxOperand1
            // 
            this.textBoxOperand1.Location = new System.Drawing.Point(37, 47);
            this.textBoxOperand1.Name = "textBoxOperand1";
            this.textBoxOperand1.Size = new System.Drawing.Size(141, 20);
            this.textBoxOperand1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите второе число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOperand1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxOperand2);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.Close);
            this.MinimumSize = new System.Drawing.Size(380, 256);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxOperand2;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox textBoxOperand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

