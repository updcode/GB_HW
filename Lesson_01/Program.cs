using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {
            // HomeWork Derushko Pavel

            #region Task1_HomeWork_01

            /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст
             * рост, вес). В результате вся информация выводится в одну строчку:
             * а) используя  склеивание;
             * б) используя форматированный вывод;
             * в) используя вывод со знаком $.
             */

            Console.WriteLine("Task_1");

            Console.Write("Input name: ");
            var name = Console.ReadLine();

            Console.Write("Input surname: ");
            var surname = Console.ReadLine();

            Console.Write("Input age: ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Input weight: ");
            var weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name + " " + "Surname: " + surname + " " + "Age: " + age + " " + "Weight: " + weight);
            Console.WriteLine("Name: {0} Surname: {1} Age: {2} Weight: {3}", name, surname, age, weight);
            Console.WriteLine($"Name: {name} Surname: {surname} Age: {age} Weight: {weight} \n");

            Console.ReadKey();
            #endregion

            #region Task2_HomeWork_01

            /* Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
             * I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
             */

            Console.WriteLine("Task_2");

            Console.Write("Input Weight: ");
            var m = int.Parse(Console.ReadLine());

            Console.Write("Input Height: ");
            var h = float.Parse(Console.ReadLine());

            var l = m / (h * h);

            Console.WriteLine($"Body mass index: {l}\n");

            Console.ReadKey();

            #endregion

            #region Task3_HomeWork_01

            /* a) Написать программу, которая подсчитывает расстояние между точками с координатами x1, 
             * y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
             * используя спецификатор формата .2f (с двумя знаками после запятой);
             * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
             */

            Console.WriteLine("Task_3");

            Console.Write("Input x1: ");
            var x1 = float.Parse(Console.ReadLine());

            Console.Write("Input x2: ");
            var x2 = float.Parse(Console.ReadLine());

            Console.Write("Input y1: ");
            var y1 = float.Parse(Console.ReadLine());

            Console.Write("Input y2: ");
            var y2 = float.Parse(Console.ReadLine());

            var distance = Distance(x1, x2, y1, y2);

            Console.WriteLine("Distance = {0:F}", distance);

            Console.ReadKey();

            #endregion
        }
        public static float Distance(float x1, float x2, float y1, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
