using System;

namespace Homework_03_Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            int sumOdd = 0;
            int nums;
            string numbers = " ";

            do
            {
                Console.Write("Input number: ");
                nums = int.Parse(Console.ReadLine());

                if (nums > 0 && nums % 2 == 1)
                {
                    sumOdd += nums;
                    numbers += $"{nums} ";
                }

            } while (nums != 0);

            Console.WriteLine($"Summ odd numbers ({numbers}) = {sumOdd}");

            Console.ReadKey();
        }
    }
}
