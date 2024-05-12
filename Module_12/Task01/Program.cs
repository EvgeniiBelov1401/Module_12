using System.Diagnostics;

namespace Task01
{
    internal class Program
    {
        static int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[10000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
                Console.WriteLine(array[i]);
            }
            return array;
        }

        static int[] SortArray(int[]array)
        {
            int temp;
            for(int i=0; i<array.Length-1; i++)
            {
                for (int j=i+1; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //var time = new Stopwatch();

            var nonSortedArray=CreateArray();
            
            //time.Start();
            var sortedArray=SortArray(nonSortedArray);
            //time.Stop();

            Console.WriteLine("Сортировать массив...");
            //Console.ReadLine();
            
            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine($"Время сортировки: {time.ElapsedMilliseconds} мс");
        }
    }
}
