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
            this.SuspendLayout();
            // 
            // reading_button
            // 
            this.reading_button.Location = new System.Drawing.Point(31, 19);
            this.reading_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reading_button.Name = "reading_button";
            this.reading_button.Size = new System.Drawing.Size(387, 42);
            this.reading_button.TabIndex = 0;
            this.reading_button.Text = "Чтение файла";
            this.reading_button.UseVisualStyleBackColor = true;
            this.reading_button.Click += new System.EventHandler(this.reading_button_Click);
            // 
            // Time_of_loading
            // 
            this.Time_of_loading.AutoSize = true;
            this.Time_of_loading.Location = new System.Drawing.Point(352, 167);
            this.Time_of_loading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_of_loading.Name = "Time_of_loading";
            this.Time_of_loading.Size = new System.Drawing.Size(34, 13);
            this.Time_of_loading.TabIndex = 1;
            this.Time_of_loading.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время загрузки:";
            // 
            // Field_for_input
            // 
            this.Field_for_input.Location = new System.Drawing.Point(20, 80);
            this.Field_for_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Field_for_input.Name = "Field_for_input";
            this.Field_for_input.Size = new System.Drawing.Size(289, 20);
            this.Field_for_input.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(339, 78);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 22);
            this.Search.TabIndex = 4;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Result_list
            // 
            this.Result_list.FormattingEnabled = true;
            this.Result_list.Location = new System.Drawing.Point(20, 116);
            this.Result_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result_list.Name = "Result_list";
            this.Result_list.Size = new System.Drawing.Size(221, 173);
            this.Result_list.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Время поиска:";
            // 
            // Time_of_searching
            // 
            this.Time_of_searching.AutoSize = true;
            this.Time_of_searching.Location = new System.Drawing.Point(352, 196);
            this.Time_of_searching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Time_of_searching.Name = "Time_of_searching";
            this.Time_of_searching.Size = new System.Drawing.Size(34, 13);
            this.Time_of_searching.TabIndex = 7;
            this.Time_of_searching.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(282, 249);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(88, 40);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 322);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Time_of_searching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result_list);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Field_for_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_of_loading);
            this.Controls.Add(this.reading_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
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
    }
}

