
namespace WindowsFormsApp13
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
            this.faliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faliToolStripMenuItem,
            this.рисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faliToolStripMenuItem
            // 
            this.faliToolStripMenuItem.Name = "faliToolStripMenuItem";
            this.faliToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.faliToolStripMenuItem.Text = "fali";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунок1ToolStripMenuItem,
            this.рисунок2ToolStripMenuItem,
            this.рисунок3ToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // рисунок1ToolStripMenuItem
            // 
            this.рисунок1ToolStripMenuItem.Name = "рисунок1ToolStripMenuItem";
            this.рисунок1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рисунок1ToolStripMenuItem.Text = "Рисунок 1";
            this.рисунок1ToolStripMenuItem.Click += new System.EventHandler(this.рисунок1ToolStripMenuItem_Click);
            // 
            // рисунок2ToolStripMenuItem
            // 
            this.рисунок2ToolStripMenuItem.Name = "рисунок2ToolStripMenuItem";
            this.рисунок2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рисунок2ToolStripMenuItem.Text = "Рисунок2";
            this.рисунок2ToolStripMenuItem.Click += new System.EventHandler(this.рисунок2ToolStripMenuItem_Click);
            // 
            // рисунок3ToolStripMenuItem
            // 
            this.рисунок3ToolStripMenuItem.Name = "рисунок3ToolStripMenuItem";
            this.рисунок3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рисунок3ToolStripMenuItem.Text = "Рисунок3";
            this.рисунок3ToolStripMenuItem.Click += new System.EventHandler(this.рисунок3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок3ToolStripMenuItem;
    }
}

