using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04_Task_01
{
    class Program
    {
        private static int[] MyArr()
        {
            int[] arr = new int[20];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10001);
                Console.WriteLine(arr[i]);
            }

            return arr;
        }
        static int GetPairs(int[] arr) 
        {
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 & arr[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            /* Homework_04_Task_01 Derushko Pavel
             * Дан  целочисленный  массив  из 20 элементов.
             * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
             * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар
             * элементов массива, в которых только одно число делится на 3.
             * В данной задаче под парой подразумевается два подряд идущих элемента массива.
             * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
             */

            int[] arr = MyArr();

            int result = GetPairs(arr);

            Console.WriteLine($"Pairs count = {result}");

            Console.ReadLine();
        }
    }
}
