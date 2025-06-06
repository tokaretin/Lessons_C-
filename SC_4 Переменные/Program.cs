using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_4_Переменные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Тип_данных имя_переменной
            int a = 8;
            Console.WriteLine(a);

            int b, c;
            b = a + 1;
            c = b + 1;
            Console.WriteLine(b);
            Console.WriteLine(c);
            

            bool var = true;
            bool var2 = false;
            Console.WriteLine(var);
            Console.WriteLine(var2);

            char q = '#';
            Console.WriteLine(q);

            string s = "Первая строка";
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
