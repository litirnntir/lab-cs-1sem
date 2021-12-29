using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LAB_8
{
    class Sort
    {
        private static double MiliSecBubble = 0, MiliSecSelect = 0;

        /// <summary>
        /// Метод, заполняющий массив случайными числами
        /// </summary>
        /// <param name="n"> Длина массива </param>
        /// <param name="Array"> Массив </param>
        /// <returns> Заполненный массив </returns>
        public static int[] RandomArray(int n)
        {
            Random Rand = new Random();
            int[] Array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Array[i] = Rand.Next(-100, 100);
            }
            return Array;
        }

        /// <summary>
        /// Метод гномьей сортировки
        /// </summary>
        /// <param name="Array"> Массив </param>
        /// <param name="n"> Длина массива </param>
        /// <param name="MiliSec"> Скорость сортировки </param>
        static void Swap(int[] Array, int i, int j)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }
        public static int[] GnomeSort(int[] Array, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int i = 1;
            int j = 2;
            while (i < Array.Length)
            {
                if (Array[i - 1] > Array[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(Array, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
            stopwatch.Stop();
            MiliSecBubble = (new TimeSpan(stopwatch.ElapsedTicks)).TotalMilliseconds;

            return Array;
        }

        /// <summary>
        /// Метод сортировки Шелла
        /// </summary>
        /// <param name="Array"> Массив </param>
        /// <param name="n"> Длина массива </param>
        /// <param name="MiliSec"> Скорость сортировки </param>
        public static int[] ShellSort(int[] Array, int n)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int v;
            int step = Array.Length;
            while (step > 1)
            {
                step /= 2;
                for (int i = 0; i < Array.Length - step; i++)
                {
                    if (Array[i] > Array[i + step])
                    {
                        v = Array[i];
                        Array[i] = Array[i + step];
                        Array[i + step] = v;
                    }
                }
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    while (Array[i] > Array[i + 1])
                    {
                        v = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = v;
                    }
                }
            }

            stopwatch.Stop();
            MiliSecSelect = (new TimeSpan(stopwatch.ElapsedTicks)).TotalMilliseconds;

            return Array;
        }
        public static double GetTimeBubble()
        {
            return MiliSecBubble;
        }
        public static double GetTimeSelect()
        {
            return MiliSecSelect;
        }
    }
}
