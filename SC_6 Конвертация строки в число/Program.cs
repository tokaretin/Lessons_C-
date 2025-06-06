using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_6_Конвертация_строки_в_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string r = "4";
            Console.WriteLine("строка символ: " + r);

            int b = Convert.ToInt32(r);
            Console.WriteLine("конвертировал строку в число: " + b + '\n');


            // Сложение двух чисел
            Console.Write("Введите 1-е число: ");
            string a = Console.ReadLine();

            Console.Write("Введите 2-е число: ");
            string c = Console.ReadLine();

            int a_int = Convert.ToInt32(a);
            int b_int = Convert.ToInt32(c);

            Console.WriteLine("Сумма чисел = " + (a_int + b_int));

            Console.ReadKey();

        }
    }
}
