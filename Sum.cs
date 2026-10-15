using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace lab_6
{
    public class Sum
    {
       public static object CalculateSum()
       {
            Console.WriteLine("Введите a");
            var a = Console.ReadLine();
            Console.WriteLine("Введите b");
            var b = Console.ReadLine();
            if(int.TryParse(a, out int c) && (int.TryParse(b, out int d)))
            {
                
                return Summ(c, d);
            }
            else if (float.TryParse(a, out float c1) && float.TryParse(b, out float d1))
            {
                return Summ(c1, d1);
            }
            else if (double.TryParse(a, out double c2) && double.TryParse(b, out double d2))
            {
                return Summ(c2, d2);
            }
            else
            {
                return Summ(a, b);
            }
        }
        private static int Summ(int a, int b)
        {
            int c = a + b;
            return c;
        }
        private static double Summ(double a, double b)
        {
            double c = a + b;
            return c;
        }
        private static float Summ(float a, float b)
        {
            float c = a + b;
            return c;
        }
        private static string Summ(string a, string b)
        {
            string c = a + b;
            return c;
        }
    }
}
