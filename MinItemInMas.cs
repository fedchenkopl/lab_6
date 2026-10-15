using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6
{
    public class MinItemInMas
    {
        public static (int item, int index) minItem(List<int> mas)
        {
            int item = 1000000000;
            int index = 0;
            for(int i = 0; i < mas.Count; i++)
            {
                if(mas[i] <= item)
                {
                    item = mas[i];
                    index = i;
                }
                
            }
            return (item, index);
        }
    }
}
