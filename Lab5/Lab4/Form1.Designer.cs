namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.reading_button = new System.Windows.Forms.Button();
            this.Time_of_loading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Field_for_input = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Result_list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Time_of_searching = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.label_dist = new System.Windows.Forms.Label();
            this.text_dist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reading_button
            // 
            this.reading_button.Location = new System.Drawing.Point(41, 23);
            this.reading_button.Name = "reading_button";
            this.reading_button.Size = new System.Drawing.Size(516, 52);
            this.reading_button.TabIndex = 0;
            this.reading_button.Text = "Чтение файла";
            this.reading_button.UseVisualStyleBackColor = true;
            this.reading_button.Click += new System.EventHandler(this.reading_button_Click);
            // 
            // Time_of_loading
            // 
            this.Time_of_loading.AutoSize = true;
            this.Time_of_loading.Location = new System.Drawing.Point(470, 205);
            this.Time_of_loading.Name = "Time_of_loading";
            this.Time_of_loading.Size = new System.Drawing.Size(44, 17);
            this.Time_of_loading.TabIndex = 1;
            this.Time_of_loading.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время загрузки:";
            // 
            // Field_for_input
            // 
            this.Field_for_input.Location = new System.Drawing.Point(27, 98);
            this.Field_for_input.Name = "Field_for_input";
            this.Field_for_input.Size = new System.Drawing.Size(384, 22);
            this.Field_for_input.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(431, 93);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(126, 27);
            this.Search.TabIndex = 4;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Result_list
            // 
            this.Result_list.FormattingEnabled = true;
            this.Result_list.ItemHeight = 16;
            this.Result_list.Location = new System.Drawing.Point(27, 143);
            this.Result_list.Name = "Result_list";
            this.Result_list.Size = new System.Drawing.Size(293, 212);
            this.Result_list.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время поиска:";
            // 
            // Time_of_searching
            // 
            this.Time_of_searching.AutoSize = true;
            this.Time_of_searching.Location = new System.Drawing.Point(470, 241);
            this.Time_of_searching.Name = "Time_of_searching";
            this.Time_of_searching.Size = new System.Drawing.Size(44, 17);
            this.Time_of_searching.TabIndex = 7;
            this.Time_of_searching.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(376, 306);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 49);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label_dist
            // 
            this.label_dist.AutoSize = true;
            this.label_dist.Location = new System.Drawing.Point(337, 143);
            this.label_dist.Name = "label_dist";
            this.label_dist.Size = new System.Drawing.Size(130, 17);
            this.label_dist.TabIndex = 9;
            this.label_dist.Text = "Макс. расстояние:";
            // 
            // text_dist
            // 
            this.text_dist.Location = new System.Drawing.Point(492, 140);
            this.text_dist.Name = "text_dist";
            this.text_dist.Size = new System.Drawing.Size(65, 22);
            this.text_dist.TabIndex = 10;
            this.text_dist.Text = "3";
            this.text_dist.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.text_dist);
            this.Controls.Add(this.label_dist);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Time_of_searching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result_list);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Field_for_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_of_loading);
            this.Controls.Add(this.reading_button);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reading_button;
        private System.Windows.Forms.Label Time_of_loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Field_for_input;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox Result_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time_of_searching;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label_dist;
        private System.Windows.Forms.TextBox text_dist;
    }
}

