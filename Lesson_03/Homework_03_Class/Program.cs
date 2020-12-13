using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework_03_Derushko Pavel
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Complex complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);

            complex2.Im = 3;

            while (true)
            {
                Console.WriteLine("Chose action: '+', '-', '*'");
                var action = Console.ReadLine();
                
                if (int.TryParse(action, out int a))
                {
                    Console.WriteLine("Invalid input");
                }

                switch (action)
                {
                    case "+":
                        Console.WriteLine(complex1.Plus(complex2).ToString());
                        break;
                    case "-":
                        Console.WriteLine(complex1.Subtract(complex2).ToString());
                        break;
                    case "*":
                        Console.WriteLine(complex1.Multi(complex2).ToString());
                        break;
                }

                Console.ReadKey();
            }
            #endregion
        }

    }
}
