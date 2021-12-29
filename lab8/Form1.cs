using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class Form1 : Form
    {
        int Attempts = 3;
        double CompResult = 0;
        bool Match = false;

        int[] Array, Array2;

        ExitForm Exit = new ExitForm();
        ChessForm Chess = new ChessForm();

        void OutputArrayGnome(int[] Array, int n)
        {
            int count = dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Columns.RemoveAt(0);
            }

            dataGridView2.Visible = true;
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Columns.Add("", Array[i].ToString());
                dataGridView1.Columns[i].Frozen = false;
                dataGridView1.Columns[i].Width = 30;
            }
        }

        void OutputArrayShell(int[] Array, int n)
        {
            int count = dataGridView2.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView2.Columns.RemoveAt(0);
            }

            dataGridView1.Visible = true;
            for (int i = 0; i < n; i++)
            {
                dataGridView2.Columns.Add("", Array[i].ToString());
                dataGridView2.Columns[i].Frozen = false;
                dataGridView2.Columns[i].Width = 30;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxAlpha.Text, out _) && double.TryParse(textBoxAnswer.Text, out _) && double.TryParse(textBoxBeta.Text, out _))
            {
                if (Attempts > 1)
                {
                    Attempts--;
                    CompResult = MathProblem.MathManager(textBoxAnswer.Text, textBoxAlpha.Text, textBoxBeta.Text);
                    Match = MathProblem.MatchChecker(CompResult, textBoxAnswer.Text);
                    if (!Match)
                    {
                        labelMatch.Text = "Ваш ответ неверен\n\nПопыток осталось - " + Attempts;
                    }
                    else
                    {
                        labelMatch.Text = "Вы выиграли!!!";
                        labelCompResult.Text = "Ответ: " + Math.Round(CompResult, 8);
                        Attempts = 3;
                    }
                }
                else
                {
                    labelMatch.Text = "             Вы проиграли!!!\nИспользованы все попытки!!!";
                    labelCompResult.Text = "Правильный ответ: " + Math.Round(CompResult, 8);
                }

            }
            else
            {
                MessageBox.Show("Вводите в поле только число!!!");
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Attempts = 3;
            Match = false;
            labelMatch.Text = "";
            labelCompResult.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandom.Checked)
            {
                labelManned.Hide();
                textBoxManned.Hide();

                labelRandArray.Show();
            }
            else
            {
                labelManned.Show();
                textBoxManned.Show();

                labelRandArray.Hide();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            labelGnome.Text = "";
            labelShell.Text = "";
            labelTimeGnome.Text = "";
            labelTimeShell.Text = "";

            if (int.TryParse(textBoxElements.Text, out _) && int.Parse(textBoxElements.Text) > 0)
            {
                int n = int.Parse(textBoxElements.Text);

                if (checkBoxRandom.Checked)
                {
                    int count = randArray.Columns.Count;
                    for (int i = 0; i < count; i++)
                    {
                        randArray.Columns.RemoveAt(0);
                    }

                    randArray.Visible = true;
                    randArray.RowCount = 1;
                    randArray.Rows[0].Frozen = false;
                    Array = Sort.RandomArray(n);
                    labelRandArray.Text = "Исходный массив: ";
                    for (int i = 0; i < n; i++)
                    {
                        randArray.Columns.Add("", Array[i].ToString());
                        randArray.Columns[i].Frozen = false;
                        randArray.Columns[i].Width = 30;
                    }
                }
                else
                {
                    Array = textBoxManned.Text.Split(' ').Select(int.Parse).ToArray();
                }

                Array2 = Array;

                Array = Sort.GnomeSort(Array, n);
                OutputArrayGnome(Array, int.Parse(textBoxElements.Text));

                Array2 = Sort.ShellSort(Array, n);
                OutputArrayShell(Array2, int.Parse(textBoxElements.Text));

                labelTimeGnome.Text = Sort.GetTimeBubble() + " мс";

                labelTimeShell.Text = Sort.GetTimeSelect() + " мс";
            }
            else
            {
                MessageBox.Show("Введите целое натуральное положительное число в поле размера массива!!!");
            }
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Горбунцова А.А. 6101-090301D\nНажмите для продолжения");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = "Количество цифр , найденных в тексте: " + StringManager.SumNum(textBox1.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonChessStart_Click(object sender, EventArgs e)
        {
            Chess.ShowDialog();
        }

        private void returnString_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            textBox1.Text = resources.GetString("textBox1.Text");
        }

    }
}
