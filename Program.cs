namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = Sum.CalculateSum();
            Mas mas = new Mas();
            List<int> list = mas.GetIntList();
            var result = MinItemInMas.minItem(list);
            int min = result.item;
            int index = result.index;
            Print.output(sum);
            Print.output(list);
            Print.output(min, index);

        }
    }
}
