namespace Exercise_12_01_03
{
    internal class Program
    {
        static void ArrayCount()
        {
            Console.Write("Сколько элементов будет в массиве: ");
            int count=int.Parse(Console.ReadLine());
            string[]array=new string[count];
            for (int i=0; i<count; i++)
            {
                Console.Write($"Элемент №{i+1}: ");
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("\n\nВсе элементы записаны!");
        }
        static void Main(string[] args)
        {
            ArrayCount();
        }
    }
}
