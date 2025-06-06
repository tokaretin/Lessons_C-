using System;
using System.Runtime.InteropServices; // для Marshal.SizeOf

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ЧИСЛОВЫЕ (целочисленные) ТИПЫ:");
            PrintType<byte>("byte");
            PrintType<sbyte>("sbyte");
        }

        static void PrintType<T>(string name) where T : struct
        {
            var type = typeof(T);
            int size = Marshal.SizeOf<T>();
            dynamic min = GetMinValue<T>();
            dynamic max = GetMaxValue<T>();
            Console.WriteLine($"Тип {name}\t| .NET {type.Name}\t| Размер = {size}\t| MIN = {min}\t| MAX = {max}");
        }

        static object GetMinValue<T>() => typeof(T).GetField("MinValue").GetValue(null);
        static object GetMaxValue<T>() => typeof(T).GetField("MaxValue").GetValue(null);
      
    }
}