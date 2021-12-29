
namespace LAB_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabePage1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelCompResult = new System.Windows.Forms.Label();
            this.labelMatch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randArray = new System.Windows.Forms.DataGridView();
            this.labelTimeShell = new System.Windows.Forms.Label();
            this.labelTimeGnome = new System.Windows.Forms.Label();
            this.labelShell = new System.Windows.Forms.Label();
            this.labelGnome = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxManned = new System.Windows.Forms.TextBox();
            this.labelManned = new System.Windows.Forms.Label();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.textBoxElements = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRandArray = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.returnString = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.TabePage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randArray)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оАвтореToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оАвтореToolStripMenuItem
            // 
            this.оАвтореToolStripMenuItem.Name = "оАвтореToolStripMenuItem";
            this.оАвтореToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.оАвтореToolStripMenuItem.Text = "О авторе";
            this.оАвтореToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TabePage1
            // 
            this.TabePage1.Controls.Add(this.tabPage1);
            this.TabePage1.Controls.Add(this.tabPage2);
            this.TabePage1.Controls.Add(this.tabPage3);
            this.TabePage1.Controls.Add(this.tabPage4);
            this.TabePage1.Location = new System.Drawing.Point(0, 23);
            this.TabePage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabePage1.Name = "TabePage1";
            this.TabePage1.SelectedIndex = 0;
            this.TabePage1.Size = new System.Drawing.Size(700, 314);
            this.TabePage1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRestart);
            this.tabPage1.Controls.Add(this.labelCompResult);
            this.tabPage1.Controls.Add(this.labelMatch);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxAnswer);
            this.tabPage1.Controls.Add(this.textBoxBeta);
            this.tabPage1.Controls.Add(this.textBoxAlpha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(692, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Функция";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(470, 250);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(114, 26);
            this.buttonRestart.TabIndex = 10;
            this.buttonRestart.Text = "Сброс";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelCompResult
            // 
            this.labelCompResult.AutoSize = true;
            this.labelCompResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompResult.Location = new System.Drawing.Point(461, 178);
            this.labelCompResult.Name = "labelCompResult";
            this.labelCompResult.Size = new System.Drawing.Size(0, 15);
            this.labelCompResult.TabIndex = 9;
            // 
            // labelMatch
            // 
            this.labelMatch.AutoSize = true;
            this.labelMatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMatch.Location = new System.Drawing.Point(461, 128);
            this.labelMatch.Name = "labelMatch";
            this.labelMatch.Size = new System.Drawing.Size(0, 15);
            this.labelMatch.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(470, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(168, 193);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(159, 29);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(237, 160);
            this.textBoxBeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(90, 29);
            this.textBoxBeta.TabIndex = 5;
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(248, 124);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(79, 29);
            this.textBoxAlpha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите ответ : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение Beta : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите значение Alpha : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 52);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.randArray);
            this.tabPage2.Controls.Add(this.labelTimeShell);
            this.tabPage2.Controls.Add(this.labelTimeGnome);
            this.tabPage2.Controls.Add(this.labelShell);
            this.tabPage2.Controls.Add(this.labelGnome);
            this.tabPage2.Controls.Add(this.buttonSort);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxManned);
            this.tabPage2.Controls.Add(this.labelManned);
            this.tabPage2.Controls.Add(this.checkBoxRandom);
            this.tabPage2.Controls.Add(this.textBoxElements);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.labelRandArray);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(692, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сортировки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(325, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(362, 43);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(322, 43);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            // 
            // randArray
            // 
            this.randArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randArray.Location = new System.Drawing.Point(441, 26);
            this.randArray.Name = "randArray";
            this.randArray.RowTemplate.Height = 25;
            this.randArray.Size = new System.Drawing.Size(246, 50);
            this.randArray.TabIndex = 15;
            this.randArray.Visible = false;
            // 
            // labelTimeShell
            // 
            this.labelTimeShell.AutoSize = true;
            this.labelTimeShell.Location = new System.Drawing.Point(382, 200);
            this.labelTimeShell.Name = "labelTimeShell";
            this.labelTimeShell.Size = new System.Drawing.Size(0, 15);
            this.labelTimeShell.TabIndex = 13;
            // 
            // labelTimeGnome
            // 
            this.labelTimeGnome.AutoSize = true;
            this.labelTimeGnome.Location = new System.Drawing.Point(3, 200);
            this.labelTimeGnome.Name = "labelTimeGnome";
            this.labelTimeGnome.Size = new System.Drawing.Size(0, 15);
            this.labelTimeGnome.TabIndex = 12;
            // 
            // labelShell
            // 
            this.labelShell.AutoSize = true;
            this.labelShell.Location = new System.Drawing.Point(382, 125);
            this.labelShell.Name = "labelShell";
            this.labelShell.Size = new System.Drawing.Size(0, 15);
            this.labelShell.TabIndex = 11;
            // 
            // labelGnome
            // 
            this.labelGnome.AutoSize = true;
            this.labelGnome.Location = new System.Drawing.Point(5, 125);
            this.labelGnome.Name = "labelGnome";
            this.labelGnome.Size = new System.Drawing.Size(0, 15);
            this.labelGnome.TabIndex = 10;
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSort.Location = new System.Drawing.Point(35, 233);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(129, 36);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Сортировать!";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(382, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 38);
            this.label9.TabIndex = 8;
            this.label9.Text = "Время выполнения \r\nсортировки Шелла: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(382, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "Результат сортировки Шелла : \r\n(по возрастанию)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "Время выполнения \r\nГномьей сортировки: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Результат Гномьей сортировки: \r\n(по убыванию)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxManned
            // 
            this.textBoxManned.Location = new System.Drawing.Point(441, 36);
            this.textBoxManned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxManned.Name = "textBoxManned";
            this.textBoxManned.Size = new System.Drawing.Size(246, 23);
            this.textBoxManned.TabIndex = 4;
            // 
            // labelManned
            // 
            this.labelManned.AutoSize = true;
            this.labelManned.Location = new System.Drawing.Point(325, 36);
            this.labelManned.Name = "labelManned";
            this.labelManned.Size = new System.Drawing.Size(99, 15);
            this.labelManned.TabIndex = 3;
            this.labelManned.Text = "Введите массив :";
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(382, 10);
            this.checkBoxRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(278, 19);
            this.checkBoxRandom.TabIndex = 2;
            this.checkBoxRandom.Text = "Заполнить массив случайными занчениями :";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.Click += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // textBoxElements
            // 
            this.textBoxElements.Location = new System.Drawing.Point(5, 35);
            this.textBoxElements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxElements.Name = "textBoxElements";
            this.textBoxElements.Size = new System.Drawing.Size(204, 23);
            this.textBoxElements.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите количество элементов: ";
            // 
            // labelRandArray
            // 
            this.labelRandArray.AutoSize = true;
            this.labelRandArray.Location = new System.Drawing.Point(325, 32);
            this.labelRandArray.Name = "labelRandArray";
            this.labelRandArray.Size = new System.Drawing.Size(0, 15);
            this.labelRandArray.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.returnString);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(692, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Строки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 240);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Считать ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(108, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Количество цифр , найденных в тексте: 3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 158);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Исходный \r\nтекст:";
            // 
            // returnString
            // 
            this.returnString.Location = new System.Drawing.Point(525, 240);
            this.returnString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnString.Name = "returnString";
            this.returnString.Size = new System.Drawing.Size(144, 35);
            this.returnString.TabIndex = 3;
            this.returnString.Text = "Вернуть изначальную строку";
            this.returnString.UseVisualStyleBackColor = true;
            this.returnString.Click += new System.EventHandler(this.returnString_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(692, 286);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Шахматы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "Начать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonChessStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.TabePage1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabePage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randArray)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl TabePage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelMatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label labelCompResult;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxManned;
        private System.Windows.Forms.Label labelManned;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.TextBox textBoxElements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label labelGnome;
        private System.Windows.Forms.Label labelTimeShell;
        private System.Windows.Forms.Label labelTimeGnome;
        private System.Windows.Forms.Label labelShell;
        private System.Windows.Forms.Label labelRandArray;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button returnString;
        private System.Windows.Forms.DataGridView randArray;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

