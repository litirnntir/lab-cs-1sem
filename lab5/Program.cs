using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace lab
{
    class Program
    {

        static double CorrectAnswer(double a, double b) // объявление метода: правильный ответ
        {
            // объявления переменных
            double f;
            double pi = Math.PI;
            double sin = Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * pi));
            double cos = Math.Cos(a + b);

            if (cos < 0)
            {
                f = sin - Math.Pow(Math.Abs(cos), 1.0 / 3.0);
            }

            else
            {
                f = sin + Math.Pow(cos, 1.0 / 3.0);
            }
            return f;
        }

        static double Ask() // объявление нового метода: вопрос пользователю
        {
            Console.WriteLine("Чему равно значение функции: sin((a^3 + b^5)/2pi)+(cos(a+b))^(1/3)?");
            double answer;
            while (!double.TryParse(Console.ReadLine(), out answer))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            return answer;
        }

        static void PrintAnswer(double f, double answer) // объявление нового метода: проверка ответа
        {
            int n = 3;
            while (n > 0)
            {
                if (answer == f)
                {
                    n = 0;
                    Console.WriteLine("\nВаш ответ полностью верен!\n\nНажмите для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (Math.Round(f, 2) == answer)
                {
                    n = 0;
                    Console.WriteLine("\nВаш ответ верен!\n\nНажмите для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    n -= 1;

                    if (n != 0)
                    {
                        Console.WriteLine("Ваш ответ неверен\n\nПопыток осталось - " + n);
                        while (!double.TryParse(Console.ReadLine(), out answer))
                        {
                            Console.Write("Неверный формат!\nВведите число: ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали!Верный ответ равен: " + f + "\nНажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }

        static void TryToGuess() // объявление нового метода: игра
        {
            Console.Clear();
            Console.WriteLine("Введите значения параметров функции: "); // ярлык ввода значений
            Console.Write("a = ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            Console.Write("b = ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            double f = CorrectAnswer(a, b);
            double answer = Ask();
            PrintAnswer(f, answer);
        }

        static Array fillArrayRandom()
        {
            Random rnd = new Random();
            int size = rnd.Next(3, 15);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(-50, 50);
            }
            return arr;
        }

        static Array fillArray()
        {
            Console.WriteLine("Введите количество элементов массива");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            int[] arr = new int[size];
            Console.WriteLine("Введите массив");
            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Неверный формат!\nВведите число: ");
                }
            }
            return arr;
        }

        static Array sortArrayShell(int[] arr)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int step = arr.Length / 2; step > 0; step /= 2)
            {
                for (int i = step; i < arr.Length; i++)
                {
                    for (int j = i - step; j >= 0 && arr[j] > arr[j + step]; j -= step)
                    {
                        int x = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = x;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Время, затраченное на сортировку Шелла = " + stopWatch.ElapsedTicks + " тика(ов)\n");
            return arr;
        }

        public static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;

        }

        static Array sortArrayGnome(int[] arr)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int i = 1;
            int j = 2;
            while (i < arr.Length)
            {
                if (arr[i - 1] < arr[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    swap(ref arr[i - 1], ref arr[i]);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Время, затраченное на гномью сортировку = " + stopWatch.ElapsedTicks + " тика(ов)\n");
            return arr;
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.Write("\n\n");
        }
        static void sortMain()
        {
            char answer;
            bool isGood = false;
            int menu;
            Console.Clear();
            Console.WriteLine("1 - Заполнить массив случайными значениями\n2 - Заполнить массив самостоятельно\n");
            int[] arr;
            bool isOk = false;
            while (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.Write("Неверный формат!\nВведите число: ");
            }
            while (isOk != true)
            {
                switch (menu)
                {
                    case 1:
                        do
                        {
                            arr = (int[])fillArrayRandom();
                            Console.Clear();
                            Console.WriteLine("Ваш массив:\n");
                            printArray(arr);
                            Console.WriteLine("Нажмите Д, чтобы оставить его\nНажмите Н, чтобы сгенерировать снова");
                            while (!char.TryParse(Console.ReadLine(), out answer))
                            {
                                Console.Write("Неверный формат!\nВведите символ: ");
                            }
                            if (answer == 'Д' || answer == 'д' || answer == 'l' || answer == 'L')
                            {
                                isGood = true;
                            }
                            else if (answer == 'Н' || answer == 'н' || answer == 'y' || answer == 'Y')
                            {
                                Console.Clear();
                                isGood = false;
                            }
                            else
                            {
                                Console.WriteLine("Неверный символ");
                                while (!char.TryParse(Console.ReadLine(), out answer))
                                {
                                    Console.Write("Неверный формат!\nВведите символ: ");
                                }
                            }
                        }
                        while (isGood == false);
                        sortArrayShell(arr);
                        sortArrayGnome(arr);
                        Console.WriteLine("Отсортированный массив:\n");
                        printArray(arr);
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    case 2:
                        do
                        {
                            arr = (int[])fillArray();
                            Console.Clear();
                            Console.WriteLine("Ваш массив:\n");
                            printArray(arr);
                            Console.WriteLine("Нажмите Д, чтобы оставить его\nНажмите Н, чтобы сгенерировать снова");
                            while (!char.TryParse(Console.ReadLine(), out answer))
                            {
                                Console.Write("Неверный формат!\nВведите символ: ");
                            }
                            if (answer == 'Д' || answer == 'д' || answer == 'l' || answer == 'L')
                            {
                                isGood = true;
                            }
                            else if (answer == 'Н' || answer == 'н' || answer == 'y' || answer == 'Y')
                            {
                                Console.Clear();
                                isGood = false;
                            }
                            else
                            {
                                Console.WriteLine("Неверный символ");
                                while (!char.TryParse(Console.ReadLine(), out answer))
                                {
                                    Console.Write("Неверный формат!\nВведите символ: ");
                                }
                            }
                        }
                        while (isGood == false);
                        sortArrayShell(arr);
                        sortArrayGnome(arr);
                        Console.WriteLine("Отсортированный массив:\n");
                        printArray(arr);
                        Console.WriteLine("Нажмите любую кнопку для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    default:

                        Console.WriteLine("Неверное число\nВведите снова");
                        while (!int.TryParse(Console.ReadLine(), out menu))
                        {
                            Console.Write("Неверный формат!\nВведите число: ");
                        }
                        break;
                }

            }
        }

        static void printPlayGround(int[,] playGround)
        {
            for (int i = 0; i < playGround.GetLength(0); i++)
            {
                for (int j = 0; j < playGround.GetLength(1); j++)
                {
                    Console.Write(playGround[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] rook()
        {
            int i;
            Random rnd = new Random();
            int centerX = rnd.Next(0, 7);
            int centerY = rnd.Next(0, 7);
            int[,] playGround =
{
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
            while (i < playGround.GetLength(0) && i >= 0)
            {
                playGround[i, centerY] = 2;
                i++;
            }
            i = centerX - 1;
            while (i < playGround.GetLength(0) && i >= 0)
            {
                playGround[i, centerY] = 2;
                i--;
            }
            i = centerY + 1;
            while (i < playGround.GetLength(1) && i >= 0)
            {
                playGround[centerX, i] = 2;
                i++;
            }
            i = centerY - 1;
            while (i < playGround.GetLength(1) && i >= 0)
            {
                playGround[centerX, i] = 2;
                i--;
            }
            return playGround;
        }

        static int[,] bishop()
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
            return playGround;
        }

        static int[,] knight()
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
            return playGround;
        }

        static void savePlayGround(int[,] playGround)
        {
            string path = @"C:/Users/Алексей/source/repos/Gorbuntsova6101/lab5/PlayGrounds.txt";
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                for (int i = 0; i < playGround.GetLength(0); i++)
                {
                    for (int j = 0; j < playGround.GetLength(1); j++)
                    {
                        sw.Write(String.Format("{0} ", playGround[i, j]));
                    }
                    sw.WriteLine();
                }
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("Поле успешно записано в файл\nНажмите для продолжения");
            }

        }

        static int[,] loadPlayGround()
        {
            int[,] playGround = new int[8, 8];
            string path = @"C:/Users/Алексей/source/repos/Gorbuntsova6101/lab5/PlayGrounds.txt";
            if (File.Exists(path))
            {
                try
                {
                    string[] lines = File.ReadAllLines(path);
                    char[][] element = new char[lines.Length][];
                    int index = 0;
                    foreach (string item in lines)
                    {
                        element[index] = item.Replace(" ", "").ToCharArray();
                        index++;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            playGround[i, j] = Convert.ToInt32(element[i][j] - 48);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return playGround;
        }

        static void chessGame()
        {
            int menu;
            char menu2;
            char choose;
            bool close = false;
            int choose2;


            while (close == false)
            {
                int[,] playGround = {
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
                {0, 0 , 0, 0, 0, 0, 0, 0 },
            };
                bool isOk = false;
                do
                {
                    Console.WriteLine("Загрузка последнего поля из файла или автоматическая генерация?\n1 - Автоматическая генерация\n2 - Загрузка из файла");
                    while (!int.TryParse(Console.ReadLine(), out choose2))
                    {
                        Console.WriteLine("Неверный формат!\nВведите символ: ");
                    }
                    if (choose2 == 1)
                    {
                        isOk = true;
                        Console.Clear();
                    }
                    else if (choose2 == 2)
                    {
                        playGround = loadPlayGround();
                        isOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Неверно введено число");
                    }
                }
                while (isOk == false);
                printPlayGround(playGround);
                Console.WriteLine("Выберите шахматную фигуру\n1 - Ладья\n2 - Слон\n3 - Конь");
                while (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.Write("Неверный формат!\nВведите символ: ");
                }
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        playGround = rook();
                        printPlayGround(playGround);
                        break;
                    case 2:
                        Console.Clear();
                        playGround = bishop();
                        printPlayGround(playGround);
                        break;
                    case 3:
                        Console.Clear();
                        playGround = knight();
                        printPlayGround(playGround);
                        break;
                    default:
                        Console.WriteLine("Введите корректное число");
                        break;
                }
                Console.WriteLine("\n\nНажмите любую кнопку");
                Console.ReadKey();
                Console.WriteLine("\nИграть ещё раз?\nД - да\nН - нет");

                while (!char.TryParse(Console.ReadLine(), out choose))
                {
                    Console.Write("Неверный формат!\nВведите число: ");
                }

                if (choose == 'д' || choose == 'Д' || choose == 'l' || choose == 'L')
                {
                    Console.Clear();
                }
                else if (choose == 'н' || choose == 'Н' || choose == 'y' || choose == 'Y')
                {
                    close = true;

                    Console.WriteLine("Сохранить текущее поле?\nД - Да\nН - Нет");
                    while (!char.TryParse(Console.ReadLine(), out menu2))
                    {
                        Console.Write("Неверный формат!\nВведите символ: ");
                    }

                    if (menu2 == 'н' || menu2 == 'Н' || menu2 == 'y' || menu2 == 'Y')
                    {
                        Console.Clear();
                    }
                    else if (menu2 == 'д' || menu2 == 'Д' || menu2 == 'l' || menu2 == 'L')
                    {
                        savePlayGround(playGround);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный формат значения\n\nНажмите для продолжения");
                    Console.Clear();
                }
            }
        }

        static void changeColor()
        {
            int color;
            bool isOk = false;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out color))
                {
                    Console.Write("Неверный формат!\nВведите число: ");
                }
                switch (color)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Оформление успешно изменено. Нажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Оформление успешно изменено. Нажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Оформление успешно изменено. Нажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Оформление успешно изменено. Нажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Оформление успешно изменено. Нажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        isOk = true;
                        break;
                    default:
                        Console.WriteLine("Неверное число");
                        break;
                }
            } while (isOk == false);

        }
        static void Main(string[] args)
        {

            bool exit = false;
            char exitchoose;
            int menu;

            do
            {
                Console.WriteLine("Лабораторная работа 5. \n\nМеню действий:\n1 – Отгадай ответ\n2 - Сортировка массива\n3 - Шахматы\n4 – Об авторе\n5 – Изменить цвет оформления\n6 – Выход");

                while (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.Write("Неверный формат!\nВведите число: ");
                }
                switch (menu)
                {
                    case 1:
                        TryToGuess();
                        Console.Clear();
                        continue;
                    case 2:
                        sortMain();
                        break;
                    case 3:
                        Console.Clear();
                        chessGame();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Горбунцова А.А. 6101-090301D\nНажмите для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Выберите цвет: \n1 - Черный\n2 - Темно-пурпурный\n3 - Серый\n4 - Белый\n5 - Жёлтый");
                        changeColor();
                        break;
                    case 6:
                        Console.WriteLine("Вы действительно хотите выйти?\nд - Да\nн - Нет");
                        while (!char.TryParse(Console.ReadLine(), out exitchoose))
                        {
                            Console.Write("Неверный формат!\nВведите число: ");
                        }
                        Console.Clear();

                        if (exitchoose == 'д' || exitchoose == 'Д' || exitchoose == 'l' || exitchoose == 'L')
                        {
                            exit = true;
                        }
                        else if (exitchoose == 'н' || exitchoose == 'Н' || exitchoose == 'y' || exitchoose == 'Y')
                        {
                            Console.WriteLine("Нажмите для возврата к главному меню");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат значения\n\nНажмите для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный формат значения\n\nНажмите для возврата в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (exit == false);

        }
    }
}