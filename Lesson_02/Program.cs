using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_02
{
    class Program
    {
        private static int minNumber(int a, int b, int c)
        {
            int minNum;
            if (a < b && a < c)
            {
                minNum = a;
            }
            else if (b < a && b < c)
            {
                minNum = b;
            }
            else
            {
                minNum = c;
            }

            return minNum;
        }

        static void Main(string[] args)
        {
            // Homework_Lesson_2 Pavel Derushko

            #region Task_01

            //// Написать метод, возвращающий минимальное из трёх чисел.

            int minNum = 0;

            Console.WriteLine($"Input number: ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input number: ");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Input number: ");
            var c = int.Parse(Console.ReadLine());

            minNum = minNumber(a, b, c);

            Console.WriteLine($"Min number ({a}; {b}; {c};) = {minNum}");

            Console.ReadLine();

            #endregion

            #region Task_02

            // Написать метод/программу подсчета количества цифр числа.

            Console.Write("Input number: ");
            var num = int.Parse(Console.ReadLine());

            var i = 0;

            while (num > 0)
            {
                i++;
                num /= 10;
            }

            Console.WriteLine($"Numbers : {i}");

            Console.ReadKey();

            #endregion

            #region Task_03

            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            int nums;
            int sumOdd = 0;

            do
            {
                Console.WriteLine("Input number");
                nums = int.Parse(Console.ReadLine());

                if (nums > 0 && nums % 2 == 1)
                {
                    sumOdd += nums;
                }

            } while (nums != 0);

            Console.WriteLine("Sum odd numbers: " + sumOdd);

            Console.ReadKey();

            #endregion

            #region Task_04

            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
             * (Логин: root, Password GeekBrains). Используя метод проверки логина и пароля,
             * написать программу: пользователь вводит логин и пароль, 
             * программа пропускает его дальше или не пропускает.
             * С помощью цикла do while ограничить ввод пароля тремя попытками.
             */

            var login = "root";
            var pass = "GeekBrains";

            int count = 0;
            do
            {
                Console.Write("Input your login: ");
                var logVerify = Console.ReadLine();

                Console.Write("Input your password: ");
                var passVerify = Console.ReadLine();


                if (login == logVerify && pass == passVerify)
                {
                    Console.WriteLine($"Welcome, {login}!");
                    break;
                }
                Console.WriteLine("Invalid login or password. Try again.");
                Console.ReadLine();
                ++count;
            } while (count < 3);

            Console.ReadKey();

            #endregion
        }
    }
}
