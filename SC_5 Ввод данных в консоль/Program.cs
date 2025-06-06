using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_5_Ввод_данных_в_консоль
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string str = Console.ReadLine();
            Console.WriteLine("Hello " + str + "!!! It's a great day to learn C#!");
            Console.ReadKey();
        }
    }
}
