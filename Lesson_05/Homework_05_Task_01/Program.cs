using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework_05_Task_01
{
    class Program
    {
        static bool VerifyLogin(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                bool flag = true;
                char symbol = login[0];

                if (Char.IsDigit(symbol)) 
                {
                    return false;
                }
                    
                for (int i = 1; i < login.Length; i++)
                {
                    symbol = login[i];

                    if (!(Char.IsDigit(symbol) || VerifyLatinSymbol(symbol)))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) 
                {
                    return true;
                }      
            }

            return false;
        }

        static bool VerifyLoginRegular(string login)
        {
            char symbol = login[0];

            if (Char.IsDigit(symbol))
            {
                return false;
            }

            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}")) 
            {
                return false;
            }
                
            return true;
        }

        private static bool VerifyLatinSymbol(char symbol)
        {
            var numbers = symbol;

            if ((numbers >= 65 && numbers <= 90) || (numbers >= 97 && numbers <= 122))
            {
                return true;
            }
            else
            {
                return false;
            }     
        }

        static void Main(string[] args)
        {
            /* Homework_05_Task_01 Derushko Pavel
             * Создать программу, которая будет проверять корректность ввода логина.
             * Корректным логином будет строка от 2 до 10 символов,
             * содержащая только буквы латинского алфавита
             * или цифры, при этом цифра не может быть первой:
             * а) без использования регулярных выражений;
             * б) **с использованием регулярных выражений.
             */

            while (true)
            {
                Console.Write("Input login: ");
                var login = Console.ReadLine();

                if (VerifyLogin(login) && VerifyLoginRegular(login))
                {
                    Console.WriteLine($"Login is correct. Welcome, {login}!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid login or password. Try again.");
                }
            }

            Console.ReadKey();
        }
    }
}
