using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    internal class Print
    {
        public static  void output(int c)
        {
            Console.WriteLine($"Сумма: {c}");
        }
        public static void output(List<int> lst)
        {
            Console.WriteLine($"Лист: {lst}");
        }
        public static void output(int min, int index)
        {
            Console.WriteLine($"Минимальный элемент: {min}, индекс: {index}");
        }
    }
}
