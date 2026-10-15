using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    public class Mas
    {

        private static int GetIntNum()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (int.TryParse(s, out int result))
                {
                    return result;
                }
                Console.WriteLine("Введите корректное число");
            }
        }



        public List<int> GetIntList()
        {
            Random random = new Random();

            Console.WriteLine("Введите количество элементов");
            int n = GetIntNum();

            List<int> lst = [];

            while (true)
            {
                Console.WriteLine("1 - с клавиатуры");
                Console.WriteLine("2 - рандомно");

                int type = GetIntNum();

                if (type == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Введите {i + 1} элемент");
                        lst.Add(GetIntNum());
                    }

                    Console.WriteLine($"Ваш список: {string.Join(" ", lst)}");
                    return lst;
                }
                else if (type == 2)
                {
                    for (int i = 0; i < n; i++)
                    {
                        lst.Add(random.Next(-11, 11));
                    }

                    Console.WriteLine($"Ваш список: {string.Join(" ", lst)}");
                    return lst;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }
        }



    }
}
