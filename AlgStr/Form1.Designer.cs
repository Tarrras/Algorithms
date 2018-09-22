namespace AlgStr
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Sliyanie = new System.Windows.Forms.Button();
            this.Blochnaya = new System.Windows.Forms.Button();
            this.Shella = new System.Windows.Forms.Button();
            this.bustraya = new System.Windows.Forms.Button();
            this.pyramyde = new System.Windows.Forms.Button();
            this.searchForKeyBinary = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newKeyBox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchForKeyLiner = new System.Windows.Forms.Button();
            this.searchForKeySentinel = new System.Windows.Forms.Button();
            this.interpolyarnui = new System.Windows.Forms.Button();
            this.searchForKeyFibonachi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 179);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить список";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoadList);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(115, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(162, 374);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(6, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 173);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистить список";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DeleteList);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox2.Location = new System.Drawing.Point(402, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(162, 374);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // Sliyanie
            // 
            this.Sliyanie.Location = new System.Drawing.Point(283, 42);
            this.Sliyanie.Name = "Sliyanie";
            this.Sliyanie.Size = new System.Drawing.Size(113, 70);
            this.Sliyanie.TabIndex = 5;
            this.Sliyanie.Text = "Сортировка слиянием";
            this.Sliyanie.UseVisualStyleBackColor = true;
            this.Sliyanie.Click += new System.EventHandler(this.Sliyanie_Click);
            // 
            // Blochnaya
            // 
            this.Blochnaya.Location = new System.Drawing.Point(283, 118);
            this.Blochnaya.Name = "Blochnaya";
            this.Blochnaya.Size = new System.Drawing.Size(113, 70);
            this.Blochnaya.TabIndex = 6;
            this.Blochnaya.Text = "Блочная сортировка";
            this.Blochnaya.UseVisualStyleBackColor = true;
            this.Blochnaya.Click += new System.EventHandler(this.Blochnaya_Click);
            // 
            // Shella
            // 
            this.Shella.Location = new System.Drawing.Point(283, 194);
            this.Shella.Name = "Shella";
            this.Shella.Size = new System.Drawing.Size(113, 70);
            this.Shella.TabIndex = 7;
            this.Shella.Text = "Сортировка Шелла";
            this.Shella.UseVisualStyleBackColor = true;
            this.Shella.Click += new System.EventHandler(this.Shella_Click);
            // 
            // bustraya
            // 
            this.bustraya.Location = new System.Drawing.Point(283, 270);
            this.bustraya.Name = "bustraya";
            this.bustraya.Size = new System.Drawing.Size(113, 70);
            this.bustraya.TabIndex = 8;
            this.bustraya.Text = "Быстрая сортировка";
            this.bustraya.UseVisualStyleBackColor = true;
            this.bustraya.Click += new System.EventHandler(this.bustraya_Click);
            // 
            // pyramyde
            // 
            this.pyramyde.Location = new System.Drawing.Point(283, 346);
            this.pyramyde.Name = "pyramyde";
            this.pyramyde.Size = new System.Drawing.Size(113, 70);
            this.pyramyde.TabIndex = 9;
            this.pyramyde.Text = "Пирамидальная сортировка";
            this.pyramyde.UseVisualStyleBackColor = true;
            this.pyramyde.Click += new System.EventHandler(this.pyramyde_Click);
            // 
            // searchForKeyBinary
            // 
            this.searchForKeyBinary.Location = new System.Drawing.Point(632, 128);
            this.searchForKeyBinary.Name = "searchForKeyBinary";
            this.searchForKeyBinary.Size = new System.Drawing.Size(139, 37);
            this.searchForKeyBinary.TabIndex = 10;
            this.searchForKeyBinary.Text = "Бинарный поиск";
            this.searchForKeyBinary.UseVisualStyleBackColor = true;
            this.searchForKeyBinary.Click += new System.EventHandler(this.searchForKeyBinary_Click);
            // 
            // keyBox
            // 
            this.keyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyBox.Location = new System.Drawing.Point(632, 71);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(139, 51);
            this.keyBox.TabIndex = 11;
            this.keyBox.Text = "";
            this.keyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyBox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(632, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Поиск по ключу";
            // 
            // newKeyBox
            // 
            this.newKeyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newKeyBox.Location = new System.Drawing.Point(632, 371);
            this.newKeyBox.Name = "newKeyBox";
            this.newKeyBox.Size = new System.Drawing.Size(139, 45);
            this.newKeyBox.TabIndex = 13;
            this.newKeyBox.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(632, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Найденный элемент";
            // 
            // searchForKeyLiner
            // 
            this.searchForKeyLiner.Location = new System.Drawing.Point(632, 171);
            this.searchForKeyLiner.Name = "searchForKeyLiner";
            this.searchForKeyLiner.Size = new System.Drawing.Size(139, 37);
            this.searchForKeyLiner.TabIndex = 15;
            this.searchForKeyLiner.Text = "Линейный поиск";
            this.searchForKeyLiner.UseVisualStyleBackColor = true;
            this.searchForKeyLiner.Click += new System.EventHandler(this.searchForKeyLiner_Click);
            // 
            // searchForKeySentinel
            // 
            this.searchForKeySentinel.Location = new System.Drawing.Point(632, 214);
            this.searchForKeySentinel.Name = "searchForKeySentinel";
            this.searchForKeySentinel.Size = new System.Drawing.Size(139, 37);
            this.searchForKeySentinel.TabIndex = 16;
            this.searchForKeySentinel.Text = "Поиск со сторожем";
            this.searchForKeySentinel.UseVisualStyleBackColor = true;
            this.searchForKeySentinel.Click += new System.EventHandler(this.searchForKeySentinel_Click);
            // 
            // interpolyarnui
            // 
            this.interpolyarnui.Location = new System.Drawing.Point(632, 257);
            this.interpolyarnui.Name = "interpolyarnui";
            this.interpolyarnui.Size = new System.Drawing.Size(139, 37);
            this.interpolyarnui.TabIndex = 17;
            this.interpolyarnui.Text = "Интерполяционный поиск";
            this.interpolyarnui.UseVisualStyleBackColor = true;
            this.interpolyarnui.Click += new System.EventHandler(this.interpolyarnui_Click);
            // 
            // searchForKeyFibonachi
            // 
            this.searchForKeyFibonachi.Location = new System.Drawing.Point(632, 299);
            this.searchForKeyFibonachi.Name = "searchForKeyFibonachi";
            this.searchForKeyFibonachi.Size = new System.Drawing.Size(139, 37);
            this.searchForKeyFibonachi.TabIndex = 18;
            this.searchForKeyFibonachi.Text = "Фибоначи";
            this.searchForKeyFibonachi.UseVisualStyleBackColor = true;
            this.searchForKeyFibonachi.Click += new System.EventHandler(this.searchForKeyFibonachi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchForKeyFibonachi);
            this.Controls.Add(this.interpolyarnui);
            this.Controls.Add(this.searchForKeySentinel);
            this.Controls.Add(this.searchForKeyLiner);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.newKeyBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.searchForKeyBinary);
            this.Controls.Add(this.pyramyde);
            this.Controls.Add(this.bustraya);
            this.Controls.Add(this.Shella);
            this.Controls.Add(this.Blochnaya);
            this.Controls.Add(this.Sliyanie);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Sliyanie;
        private System.Windows.Forms.Button Blochnaya;
        private System.Windows.Forms.Button Shella;
        private System.Windows.Forms.Button bustraya;
        private System.Windows.Forms.Button pyramyde;
        private System.Windows.Forms.Button searchForKeyBinary;
        private System.Windows.Forms.RichTextBox keyBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox newKeyBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button searchForKeyLiner;
        private System.Windows.Forms.Button searchForKeySentinel;
        private System.Windows.Forms.Button interpolyarnui;
        private System.Windows.Forms.Button searchForKeyFibonachi;
    }
}

