using System;

namespace lab0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения параметров функции: ");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Чему равно значение функции: sin((a^3 + b^5)/2pi)+(cos(a+b))^(1/3)? ");
            double answer = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double sin = Math.Sin((Math.Pow(a, 3) + Math.Pow(b, 5)) / (2 * pi));
            double cos = Math.Cos(a + b);

            if (cos < 0)
            {

                double f = sin - Math.Pow(Math.Abs(cos), 1.0 / 3.0);
                Console.WriteLine("Правильное значение функции: " + f);
            }

            else
            {
                double f = sin + Math.Pow(cos, 1.0 / 3.0);
                Console.WriteLine("Правильное значение функции: " + f);
            }
        }
    }
}
