using BenchmarkDotNet.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class Testing
    {
        [Benchmark]
        public void SortArray()
        {
            Random random = new Random();
            int[] array = new int[10000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Сортировать массив...");
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        [Benchmark]
        public void SortList()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10000; i++)
            {

                list.Add(random.Next(1000));
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
