using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_Task_03
{
    class Program
    {
        static bool permuitationWord(string str1, string str2)
        {
            return str1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(str2.Select(Char.ToUpper).OrderBy(x => x));
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input first word: ");
                var s1 = Console.ReadLine();

                Console.Write("Input second word: ");
                var s2 = Console.ReadLine();

                if (permuitationWord(s1, s2) == true)
                {
                    Console.WriteLine($"{s1} is a permutation of {s2}");
                }
                else
                {
                    Console.WriteLine($"{s1} is not a permutation of {s2}");
                }

                Console.ReadKey();
            }
        }
    }
}
