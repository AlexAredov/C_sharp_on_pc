
namespace WindowsFormsApp5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходALTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.развернутаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветНомер1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветНомер2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветНомер3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.размерФормыToolStripMenuItem,
            this.цветФонаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходALTEToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходALTEToolStripMenuItem
            // 
            this.выходALTEToolStripMenuItem.Name = "выходALTEToolStripMenuItem";
            this.выходALTEToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.выходALTEToolStripMenuItem.Text = "Выход (ALT+E)";
            this.выходALTEToolStripMenuItem.Click += new System.EventHandler(this.выходALTEToolStripMenuItem_Click);
            // 
            // размерФормыToolStripMenuItem
            // 
            this.размерФормыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутаяToolStripMenuItem,
            this.нормальнаяToolStripMenuItem});
            this.размерФормыToolStripMenuItem.Name = "размерФормыToolStripMenuItem";
            this.размерФормыToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.размерФормыToolStripMenuItem.Text = "Размер формы";
            // 
            // развернутаяToolStripMenuItem
            // 
            this.развернутаяToolStripMenuItem.Name = "развернутаяToolStripMenuItem";
            this.развернутаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.развернутаяToolStripMenuItem.Text = "Развернутая";
            this.развернутаяToolStripMenuItem.Click += new System.EventHandler(this.развернутаяToolStripMenuItem_Click);
            // 
            // нормальнаяToolStripMenuItem
            // 
            this.нормальнаяToolStripMenuItem.Name = "нормальнаяToolStripMenuItem";
            this.нормальнаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.нормальнаяToolStripMenuItem.Text = "Нормальная";
            this.нормальнаяToolStripMenuItem.Click += new System.EventHandler(this.нормальнаяToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветНомер1ToolStripMenuItem,
            this.цветНомер2ToolStripMenuItem,
            this.цветНомер3ToolStripMenuItem});
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // цветНомер1ToolStripMenuItem
            // 
            this.цветНомер1ToolStripMenuItem.Name = "цветНомер1ToolStripMenuItem";
            this.цветНомер1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цветНомер1ToolStripMenuItem.Text = "Цвет номер 1";
            this.цветНомер1ToolStripMenuItem.Click += new System.EventHandler(this.цветНомер1ToolStripMenuItem_Click);
            // 
            // цветНомер2ToolStripMenuItem
            // 
            this.цветНомер2ToolStripMenuItem.Name = "цветНомер2ToolStripMenuItem";
            this.цветНомер2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цветНомер2ToolStripMenuItem.Text = "Цвет номер 2";
            this.цветНомер2ToolStripMenuItem.Click += new System.EventHandler(this.цветНомер2ToolStripMenuItem_Click);
            // 
            // цветНомер3ToolStripMenuItem
            // 
            this.цветНомер3ToolStripMenuItem.Name = "цветНомер3ToolStripMenuItem";
            this.цветНомер3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цветНомер3ToolStripMenuItem.Text = "Цвет номер 3";
            this.цветНомер3ToolStripMenuItem.Click += new System.EventHandler(this.цветНомер3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходALTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерФормыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem развернутаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нормальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветНомер1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветНомер2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветНомер3ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

