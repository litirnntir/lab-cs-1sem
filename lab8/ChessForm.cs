using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class ChessForm : Form
    {
        private int Figure = 0, PosX, PosY;

        public ChessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Figure != 0)
            {
                Pen myPen = new Pen(Color.Black, 2);
                Graphics myGraphics = this.CreateGraphics();
                SolidBrush BlackBrush = new SolidBrush(Color.Black);
                SolidBrush BlueBrush = new SolidBrush(Color.Green);
                SolidBrush RedBrush = new SolidBrush(Color.Blue);
                SolidBrush WhiteBrush = new SolidBrush(Color.White);
                Random rand = new Random();

                PosX = rand.Next(0, 8);
                PosY = rand.Next(0, 8);

                myGraphics.DrawRectangle(myPen, 55, 70, 400, 400);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Rectangle Cell = new Rectangle(55 + j * 50, 70 + i * 50, 50, 50);
                        if (i % 2 == 0)
                        {
                            if (j % 2 != 0)
                            {
                                myGraphics.FillRectangle(BlackBrush, Cell);
                            }
                            else
                            {
                                myGraphics.FillRectangle(WhiteBrush, Cell);
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                myGraphics.FillRectangle(BlackBrush, Cell);
                            }
                            else
                            {
                                myGraphics.FillRectangle(WhiteBrush, Cell);
                            }
                        }


                        switch (Figure)
                        {
                            case 1:
                                if (i == PosY || j == PosX)
                                {
                                    Rectangle MoveCell = new Rectangle(55 + j * 50, 70 + i * 50, 50, 50);
                                    myGraphics.FillRectangle(BlueBrush, MoveCell);
                                }
                                break;
                            case 2:
                                if ((j == (PosX - 2) && (i == (PosY + 1) || i == (PosY - 1))) ||
                                    (j == (PosX + 2) && (i == (PosY + 1) || i == (PosY - 1))) ||
                                    (i == (PosY - 2) && (j == (PosX + 1) || j == (PosX - 1))) ||
                                    (i == (PosY + 2) && (j == (PosX + 1) || j == (PosX - 1))))
                                {
                                    Rectangle MoveCell = new Rectangle(55 + j * 50, 70 + i * 50, 50, 50);
                                    myGraphics.FillRectangle(BlueBrush, MoveCell);
                                }
                                break;
                            case 3:
                                for (int c = 0; c < 8; c++)
                                {
                                    if ((i == (PosY + c) && j == (PosX + c)) ||
                                        (i == (PosY - c) && j == (PosX - c)) ||
                                        (i == (PosY + c) && j == (PosX - c)) ||
                                        (i == (PosY - c) && j == (PosX + c)))
                                    {
                                        Rectangle MoveCell = new Rectangle(55 + j * 50, 70 + i * 50, 50, 50);
                                        myGraphics.FillRectangle(BlueBrush, MoveCell);
                                    }
                                }
                                break;
                            default:
                                break;
                        }

                        Rectangle MainCell = new Rectangle(55 + PosX * 50, 70 + PosY * 50, 50, 50);
                        myGraphics.FillRectangle(RedBrush, MainCell);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите фигуру!!!");
            }
        }

        private void radioButtonRook_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRook.Checked)
            {
                Figure = 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonHorse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHorse.Checked)
            {
                Figure = 2;
            }
        }

        private void radioButtonEleph_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEleph.Checked)
            {
                Figure = 3;
            }
        }
    }
}
