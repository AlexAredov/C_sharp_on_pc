
namespace _2Project4
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
            this.label1 = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.TextBox();
            this.pred_summa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Label();
            this.neel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите числа через запятую:";
            // 
            // numbers
            // 
            this.numbers.Location = new System.Drawing.Point(231, 10);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(171, 22);
            this.numbers.TabIndex = 1;
            // 
            // pred_summa
            // 
            this.pred_summa.Location = new System.Drawing.Point(166, 42);
            this.pred_summa.Name = "pred_summa";
            this.pred_summa.Size = new System.Drawing.Size(124, 22);
            this.pred_summa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Предельная сумма:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(296, 41);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(106, 23);
            this.result.TabIndex = 4;
            this.result.Text = "Рассчитать";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма:";
            // 
            // summa
            // 
            this.summa.AutoSize = true;
            this.summa.Location = new System.Drawing.Point(83, 77);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(16, 17);
            this.summa.TabIndex = 6;
            this.summa.Text = "0";
            // 
            // neel
            // 
            this.neel.AutoSize = true;
            this.neel.Location = new System.Drawing.Point(231, 107);
            this.neel.Name = "neel";
            this.neel.Size = new System.Drawing.Size(16, 17);
            this.neel.TabIndex = 7;
            this.neel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Неиспользованных элементов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 199);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.neel);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pred_summa);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numbers;
        private System.Windows.Forms.TextBox pred_summa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label summa;
        private System.Windows.Forms.Label neel;
        private System.Windows.Forms.Label label6;
    }
}

