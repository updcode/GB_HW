using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 04_Task_02 Derushko Pavel
            * Реализуйте задачу 1 в виде статического класса StaticClass;
            * a) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            * b) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            * c) **Добавьте обработку ситуации отсутствия файла на диске.
            */

            try
            {
                int[] array = StaticClass.ArrayFile("numbers.txt");

                foreach (var nums in array)
                {
                    Console.WriteLine(nums);
                }

                Console.WriteLine($"Pairs: {StaticClass.GetPairs(array)}");
            }
            catch (Exception)
            {
                Console.WriteLine("File is not find");
            }

            Console.ReadKey();
        }
    }
}
