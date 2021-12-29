using System;
using System.Diagnostics;

namespace Лабораторная_работа__7
{
    class Array
    {
        private int _n;
        public Array()
        {
            _n = 10;
        }
        public Array(int n)
        {
            _n = n;
        }

        /// <summary>
        /// Ввод элементов массива
        /// </summary>
        /// <param name="_n"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] InputRandomArray(int _n, int[] array)
        {
            Random rnd = new Random();
            for (int i = 1; i < _n; i++)
                array[i] = rnd.Next(-10, 10);
            return array;
        }
        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="array"></param>
        static void OutputArray(int[] array)
        {
            foreach (int i in array)
                Console.Write("{0} ", i);
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Сортировка Шелла
        /// </summary>
        /// <param name="array"></param>
        static void ShellSort(int[] array)
        {
            int v;
            int step = array.Length;
            while (step > 1)
            {
                step /= 2;
                for (int i = 0; i < array.Length - step; i++)
                {
                    if (array[i] > array[i + step])
                    {
                        v = array[i];
                        array[i] = array[i + step];
                        array[i + step] = v;
                    }
                }
                for (int i = 0; i < array.Length - 1; i++)
                {
                    while (array[i] > array[i + 1])
                    {
                        v = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = v;
                    }
                }
            }

            Console.Write(string.Join(",", array));
        }

        /// <summary>
        /// Гномья сортировка
        /// </summary>
        /// <param name="array"></param> 

        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void GnomeSort(int[] array)
        {
            int i = 1;
            int j = 2;
            while (i < array.Length)
            {
                if (array[i - 1] > array[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(array, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }

            Console.Write(string.Join(",", array));
        }

        /// <summary>
        /// Подсчёт и вывод времени сортировок
        /// </summary>
        /// <param name="_n"></param>
        /// <returns></returns>
        public static string Arr(int _n)
        {
            string time;
            int[] array = new int[_n];
            InputRandomArray(_n, array);
            OutputArray(array);

            Console.WriteLine("Сортировка Шелла");
            var timeShell = new Stopwatch();
            timeShell.Start();
            ShellSort(array);
            timeShell.Stop();
            Console.WriteLine($"\nВремя выполнения сортировки Шелла: {timeShell.Elapsed} с");

            Console.WriteLine();

            Console.WriteLine("Гномья сортировка");
            var timeGnome = new Stopwatch();
            timeGnome.Start();
            GnomeSort(array);
            timeGnome.Stop();
            Console.WriteLine($"\nВремя выполнения Гномьей сортировки: {timeGnome.Elapsed} с");

            Console.WriteLine();

            if (timeShell.Elapsed > timeGnome.Elapsed)
            {
                time = "Время выполнения Гномьей сортировки быстрее";
            }
            else
            {
                time = "Время выполнения сортировки Шелла быстрее";
            }
            return time;
        }

        /// <summary>
        /// Задание количества элементов массива
        /// </summary>
        /// <returns></returns>
        public string Element()
        {
            string result = "";
            Console.WriteLine("Выберите способ ввода массива");
            Console.WriteLine("1 - Количество элементов по умолчанию");
            Console.WriteLine("2 - Задать количество элементов");
            int k = Control.K();
            switch (k)
            {
                case 1:
                    Arr(_n);
                    break;
                case 2:
                    Console.WriteLine("Введите количество элементов массива");
                    _n = int.Parse(Console.ReadLine());
                    result = Array.Arr(_n);
                    break;
            }
            return result;
        }
    }
}
