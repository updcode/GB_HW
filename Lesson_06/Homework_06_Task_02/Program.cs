using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace Homework_06_Task_02
{
    public delegate double Fun(double x);

    class Program
    {
        
        public static void Func(string flname, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(flname, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string flName, out double min)
        {
            FileStream fs = new FileStream(flName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();

            return array;
        }

        static double SecondDegree(double x)
        {
            return x * x;
        }

        static double ThirdDegree(double x)
        {
            return x * x * x;
        }

        static double MySqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static double Sin(double x)
        {
            return Math.Sin(x);
        }

        static int GetInt(int max)
        {
            while (true) 
            {
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                {
                    Console.Write("Invalid input. Retry: ", max);
                }
                else 
                {
                    return x;
                }
            }
        }

        static void Section(out double start, out double end)
        {
            string[] section = Console.ReadLine().Split(' ');
            start = double.Parse(section[0], CultureInfo.InvariantCulture);
            end = double.Parse(section[1], CultureInfo.InvariantCulture);
        }

        static void Print(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        static void Main(string[] args)
        {
            /* Homework_06_Task_02 Derushko Pavel
             * Модифицировать программу нахождения минимума функции так, чтобы можно было
             * передавать функцию в виде делегата. 
             * а) Сделать меню с различными функциями и представить пользователю выбор, для какой
             * функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, 
             * в котором хранятся различные функции.
             * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она 
             * возвращает минимум через параметр (с использованием модификатора out). 
             */

            List<Fun> functions = new List<Fun> { new Fun(SecondDegree), new Fun(ThirdDegree), new Fun(MySqrt), new Fun(Sin) };

            Console.WriteLine("Choise Func:");
            Console.WriteLine("1 f(x)=y^2");
            Console.WriteLine("2 f(x)=y^3");
            Console.WriteLine("3 f(x)=y^1/2");
            Console.WriteLine("4 f(x)=Sin(y)");

            int choise = GetInt(functions.Count);

            Console.WriteLine("Input section 'х1 х2':");

            double start = 0;
            double end = 0;
            Section(out start, out end);

            Console.WriteLine("Set the step value:");
            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func("data.bin", start, end, step, functions[choise - 1]);
            double min = double.MaxValue;

            Console.WriteLine("Result: ");
            Print(start, end, step, Load("data.bin", out min));

            Console.WriteLine("Func min value: {0:0.00}", min);

            Console.ReadKey();
        }
    }
}
