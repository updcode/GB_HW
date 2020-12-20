using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_04_Task_02
{
    static class StaticClass
    {
        public static int GetPairs(int[] arr)
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

        static public int[] ArrayFile(string path)
        {
            string[] strArr = File.ReadAllLines(path);

            int[] numsArr = new int[strArr.Length];

            for (int i = 0; i < numsArr.Length; i++)
            {
                numsArr[i] = int.Parse(strArr[i]);
            }
            return numsArr;
        }
    }
}
