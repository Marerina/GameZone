namespace GameZone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эпизодыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.активныеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.завершенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсутствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активностьВПостахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ссылкиНаЭпизодыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.проверкаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.ссылкиНаЭпизодыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эпизодыToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // эпизодыToolStripMenuItem
            // 
            this.эпизодыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеToolStripMenuItem1,
            this.активныеToolStripMenuItem1,
            this.завершенныеToolStripMenuItem});
            this.эпизодыToolStripMenuItem.Name = "эпизодыToolStripMenuItem";
            this.эпизодыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.эпизодыToolStripMenuItem.Text = "Эпизоды";
            this.эпизодыToolStripMenuItem.Click += new System.EventHandler(this.эпизодыToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem1
            // 
            this.всеToolStripMenuItem1.Name = "всеToolStripMenuItem1";
            this.всеToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.всеToolStripMenuItem1.Text = "Все";
            this.всеToolStripMenuItem1.Click += new System.EventHandler(this.всеToolStripMenuItem1_Click);
            // 
            // активныеToolStripMenuItem1
            // 
            this.активныеToolStripMenuItem1.Name = "активныеToolStripMenuItem1";
            this.активныеToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.активныеToolStripMenuItem1.Text = "Активные";
            // 
            // завершенныеToolStripMenuItem
            // 
            this.завершенныеToolStripMenuItem.Name = "завершенныеToolStripMenuItem";
            this.завершенныеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.завершенныеToolStripMenuItem.Text = "Завершенные";
            // 
            // проверкаToolStripMenuItem
            // 
            this.проверкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отсутствиеToolStripMenuItem,
            this.активностьВПостахToolStripMenuItem,
            this.списокПользователейToolStripMenuItem});
            this.проверкаToolStripMenuItem.Name = "проверкаToolStripMenuItem";
            this.проверкаToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.проверкаToolStripMenuItem.Text = "Проверка";
            // 
            // отсутствиеToolStripMenuItem
            // 
            this.отсутствиеToolStripMenuItem.Name = "отсутствиеToolStripMenuItem";
            this.отсутствиеToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.отсутствиеToolStripMenuItem.Text = "Отсутствие";
            this.отсутствиеToolStripMenuItem.Click += new System.EventHandler(this.отсутствиеToolStripMenuItem_Click);
            // 
            // активностьВПостахToolStripMenuItem
            // 
            this.активностьВПостахToolStripMenuItem.Name = "активностьВПостахToolStripMenuItem";
            this.активностьВПостахToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.активностьВПостахToolStripMenuItem.Text = "Активность";
            this.активностьВПостахToolStripMenuItem.Click += new System.EventHandler(this.активностьВПостахToolStripMenuItem_Click);
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            this.списокПользователейToolStripMenuItem.Click += new System.EventHandler(this.списокПользователейToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // ссылкиНаЭпизодыToolStripMenuItem
            // 
            this.ссылкиНаЭпизодыToolStripMenuItem.Name = "ссылкиНаЭпизодыToolStripMenuItem";
            this.ссылкиНаЭпизодыToolStripMenuItem.Size = new System.Drawing.Size(200, 20);
            this.ссылкиНаЭпизодыToolStripMenuItem.Text = "Ссылки на форумы с эпизодами";
            this.ссылкиНаЭпизодыToolStripMenuItem.Click += new System.EventHandler(this.ссылкиНаЭпизодыToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(842, 2);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(177, 20);
            this.progressBar1.Step = 200;
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 456);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кандозаменин";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Validated += new System.EventHandler(this.Form1_Validated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эпизодыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem активныеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem завершенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отсутствиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активностьВПостахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem ссылкиНаЭпизодыToolStripMenuItem;
    }
}

