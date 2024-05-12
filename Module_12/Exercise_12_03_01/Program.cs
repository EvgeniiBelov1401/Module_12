using System.Diagnostics.Metrics;

namespace Exercise_12_03_01
{
    internal class Program
    {
        static string SearchInArray(int[] array, int value)
        {
            
            int middle = (array[0] + array[array.Length - 1]) / 2;

            if (value == middle)
            {
                return "Число найдено в массиве";
            }
            else if (value < middle)
            {

            }




            //int counter = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == value)
            //    {
            //        return $"Число найдено на позиции: {i + 1}\nДействий: {counter + 1}";
            //    }
            //    counter++;
            //}
            //return $"Число не найдено\nДействий: {counter}";
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29 };

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Введите число, которое необходимо найти: ");
            var value = int.Parse(Console.ReadLine());

            Console.WriteLine(SearchInArray(array, value));
        }
    }
}
