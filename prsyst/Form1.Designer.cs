namespace prsyst
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.direct_button = new System.Windows.Forms.Button();
            this.backward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(642, 417);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 435);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(642, 131);
            this.textBox2.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "f1;доски ",
            "f2;камень",
            "f3;булыжник",
            "f4;песок",
            "f5;кремень",
            "f6;уголь",
            "f7;дерево",
            "f8;стекло",
            "f9;железный слиток",
            "f10;золотой слиток",
            "f11;алмаз",
            "f12;красная пыль",
            "f13;верстак",
            "f14;фиолетовый краситель",
            "f15;прополис",
            "f16;печь",
            "f17;сундук",
            "f18;загрузочная воронка        ",
            "f19;палка",
            "f20;факел",
            "f21;шерсть",
            "f22;чернильные мешки",
            "f23;фонарь",
            "f24;каменная плита",
            "f25;лазуритовая руда",
            "f26;лазурит",
            "f27;вода",
            "f28;Наковальня",
            "f29;меч",
            "f30;глина",
            "f31;кожа",
            "f32;железные кусочки",
            "f33;цепь",
            "f34;топор",
            "f35;Мотыга",
            "f36;кирка",
            "f37;дверь",
            "f38;забор",
            "f39;лестница ",
            "f40;вагонетка ",
            "f41;цветочный горшок",
            "f42;бумага",
            "f43;чёрный краситель",
            "f44;пыльца",
            "f45;лодка",
            "f46;поршень",
            "f47;лопата",
            "f48;компас",
            "f49;костная мука",
            "f50;колба",
            "f51;железный блок",
            "f52;золотой блок",
            "f53;алмазный блок",
            "f54;книга",
            "f55;сахарный тростник",
            "f56;кремний",
            "f57;перо ",
            "f58; розовый краситель",
            "f59; красный краситель",
            "f60; синий краситель ",
            "f61; зелёный краситель",
            "f62; жёлтый краситель",
            "f63;шлем",
            "f64; нагрудник",
            "f65; оранжевый краситель",
            "f66;штаны",
            "f67;ботинки",
            "f68;щит",
            "f69;книжная полка",
            "f70;мак",
            "f80;стрела",
            "f81;одуванчик",
            "f82;подсолнечник",
            "f83;чернильный мешок",
            "f84;красный тюльпан",
            "f85;лазурит",
            "f86;оранжевый тюльпан ",
            "f87;нить",
            "f88;лук",
            "f89;кирпич",
            "f90;порох",
            "f91;динамит",
            "f92;пион",
            "f93;белый краситель",
            "f94;обсидиан",
            "f95;око края",
            "f96;сундук края",
            "f97;зачаровательный стол",
            "f98;кирпичный блок",
            "f99;музыкальная шкатулка",
            "f100;красный факел",
            "f101;электрические рельсы",
            "f102;ведро",
            "f103;ведро воды",
            "f104;шерсть",
            "f105;кровать",
            "f106;цветная шерсть",
            "f107;слизь",
            "f108;блок слизи",
            "f109;Костер",
            "f110;удочка",
            "f111;ножницы"});
            this.checkedListBox1.Location = new System.Drawing.Point(738, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(637, 310);
            this.checkedListBox1.TabIndex = 7;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(169, 582);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(129, 23);
            this.clear_button.TabIndex = 9;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // direct_button
            // 
            this.direct_button.Location = new System.Drawing.Point(12, 582);
            this.direct_button.Name = "direct_button";
            this.direct_button.Size = new System.Drawing.Size(129, 23);
            this.direct_button.TabIndex = 10;
            this.direct_button.Text = "ПРЯМОЙ";
            this.direct_button.UseVisualStyleBackColor = true;
            this.direct_button.Click += new System.EventHandler(this.direct_button_Click);
            // 
            // backward
            // 
            this.backward.Location = new System.Drawing.Point(324, 582);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(129, 23);
            this.backward.TabIndex = 11;
            this.backward.Text = "ОБРАТНЫЙ";
            this.backward.UseVisualStyleBackColor = true;
            this.backward.Click += new System.EventHandler(this.backward_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "правила";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "f1;доски ",
            "f2;камень",
            "f3;булыжник",
            "f4;песок",
            "f5;кремень",
            "f6;уголь",
            "f7;дерево",
            "f8;стекло",
            "f9;железный слиток",
            "f10;золотой слиток",
            "f11;алмаз",
            "f12;красная пыль",
            "f13;верстак",
            "f14;фиолетовый краситель",
            "f15;прополис",
            "f16;печь",
            "f17;сундук",
            "f18;загрузочная воронка        ",
            "f19;палка",
            "f20;факел",
            "f21;шерсть",
            "f22;чернильные мешки",
            "f23;фонарь",
            "f24;каменная плита",
            "f25;лазуритовая руда",
            "f26;лазурит",
            "f27;вода",
            "f28;Наковальня",
            "f29;меч",
            "f30;глина",
            "f31;кожа",
            "f32;железные кусочки",
            "f33;цепь",
            "f34;топор",
            "f35;Мотыга",
            "f36;кирка",
            "f37;дверь",
            "f38;забор",
            "f39;лестница ",
            "f40;вагонетка ",
            "f41;цветочный горшок",
            "f42;бумага",
            "f43;чёрный краситель",
            "f44;пыльца",
            "f45;лодка",
            "f46;поршень",
            "f47;лопата",
            "f48;компас",
            "f49;костная мука",
            "f50;колба",
            "f51;железный блок",
            "f52;золотой блок",
            "f53;алмазный блок",
            "f54;книга",
            "f55;сахарный тростник",
            "f56;кремний",
            "f57;перо ",
            "f58; розовый краситель",
            "f59; красный краситель",
            "f60; синий краситель ",
            "f61; зелёный краситель",
            "f62; жёлтый краситель",
            "f63;шлем",
            "f64; нагрудник",
            "f65; оранжевый краситель",
            "f66;штаны",
            "f67;ботинки",
            "f68;щит",
            "f69;книжная полка",
            "f70;мак",
            "f80;стрела",
            "f81;одуванчик",
            "f82;подсолнечник",
            "f83;чернильный мешок",
            "f84;красный тюльпан",
            "f85;лазурит",
            "f86;оранжевый тюльпан ",
            "f87;нить",
            "f88;лук",
            "f89;кирпич",
            "f90;порох",
            "f91;динамит",
            "f92;пион",
            "f93;белый краситель",
            "f94;обсидиан",
            "f95;око края",
            "f96;сундук края",
            "f97;зачаровательный стол",
            "f98;кирпичный блок",
            "f99;музыкальная шкатулка",
            "f100;красный факел",
            "f101;электрические рельсы",
            "f102;ведро",
            "f103;ведро воды",
            "f104;шерсть",
            "f105;кровать",
            "f106;цветная шерсть",
            "f107;слизь",
            "f108;блок слизи",
            "f109;Костер",
            "f110;удочка",
            "f111;ножницы"});
            this.checkedListBox2.Location = new System.Drawing.Point(738, 318);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(637, 310);
            this.checkedListBox2.TabIndex = 13;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 652);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backward);
            this.Controls.Add(this.direct_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button direct_button;
        private System.Windows.Forms.Button backward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}

