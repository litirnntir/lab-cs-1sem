using System;
using System.Collections.Generic;
using System.Text;

namespace Лабораторная_работа__7
{
    class Game
    {
        static int[,] playGround = new int[8, 8];


        /// <summary>
        /// Метод, вычисляющий доступные ходы для определённой фигуры
        /// </summary>
        /// <param name="playGround"> Игровое поле </param>

        static void rook()
        {
            int l = 8;
            int[,] playGround = new int[l, l];
            Random rnd = new Random();
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                    playGround[i, j] = 0;
            }
            int k = rnd.Next(0, l);
            int t = rnd.Next(0, l);
            for (int j = 0; j < l; j++)
                playGround[k, j] = 2;
            for (int i = 0; i < l; i++)
                playGround[i, t] = 2;
            playGround[k, t] = 1;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < l; j++) Console.Write("{0} ", playGround[i, j]);
            }
        }
        static void bishop()
        {
            int i;
            int j;
            Random rnd = new Random();
            int centerX = rnd.Next(0, 7);
            int centerY = rnd.Next(0, 7);
            int[,] playGround = {
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0}
                            };
            playGround[centerX, centerY] = 1;
            i = centerX + 1;
            j = centerY + 1;
            while (i < playGround.GetLength(0) && i >= 0 && j < playGround.GetLength(1) && j >= 0)
            {
                playGround[i, j] = 2;
                i++;
                j++;
            }
            i = centerX - 1;
            j = centerY + 1;
            while (i < playGround.GetLength(0) && i >= 0 && j < playGround.GetLength(1) && j >= 0)
            {
                playGround[i, j] = 2;
                i--;
                j++;
            }
            i = centerX + 1;
            j = centerY - 1;
            while (i < playGround.GetLength(0) && i >= 0 && j < playGround.GetLength(1) && j >= 0)
            {
                playGround[i, j] = 2;
                i++;
                j--;
            }
            i = centerX - 1;
            j = centerY - 1;
            while (i < playGround.GetLength(0) && i >= 0 && j < playGround.GetLength(1) && j >= 0)
            {
                playGround[i, j] = 2;
                i--;
                j--;
            }
            for (i = 0; i < playGround.GetLength(0); i++)

            {
                for (j = 0; j < playGround.GetLength(1); j++)
                    Console.Write(playGround[i, j] + "{0}", j < playGround.GetLength(1) - 1 ? " " : "");
                Console.WriteLine();
            }

        }
        static void knight()
        {
            Random rnd = new Random();
            int centerX = rnd.Next(0, 7);
            int centerY = rnd.Next(0, 7);
            int[,] playGround = {
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0},
                                {0, 0, 0, 0, 0, 0, 0, 0}
                            };
            playGround[centerX, centerY] = 1;

            for (int i = -2; i <= 2; i += 1)
            {
                for (int j = -2; j <= 2; j += 1)
                {
                    if ((centerX + i) < playGround.GetLength(0) && (centerY + j) < playGround.GetLength(1) && (centerX + i) >= 0 && (centerY + j) >= 0 && Math.Abs(i) != Math.Abs(j) && i != 0 && j != 0)
                    {
                        playGround[centerX + i, centerY + j] = 2;
                    }
                }
            }
            for (int i = 0; i < playGround.GetLength(0); i++)

            {
                for (int j = 0; j < playGround.GetLength(1); j++)
                    Console.Write(playGround[i, j] + "{0}", j < playGround.GetLength(1) - 1 ? " " : "");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Выбор фигуры шахмат
        /// </summary>
        /// <returns></returns>

        public void Chess()
        {
            switch (Control.Menu())
            {
                case 1:
                    rook();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    bishop();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    knight();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}