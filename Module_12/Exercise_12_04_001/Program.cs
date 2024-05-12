using System.Diagnostics;

namespace Exercise_12_04_001
{
    internal class Program
    {
        static void CreateArray()
        {
            

            int[] array = new int[10000];

            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = rand.Next(1000);
                Console.WriteLine(array[i]);
            }
            
        }
        static void Main(string[] args)
        {
            var timer=new Stopwatch();
            var timeArray=new long[10];
            double middleTimeSum = 0;
            timer.Start();
            for (int i = 0;i<timeArray.Length;i++)
            {
                timer.Restart();
                CreateArray();               
                timeArray[i] = timer.ElapsedMilliseconds;
            }
            timer.Stop();

            foreach (long item in timeArray)
            {
                Console.WriteLine($"\nВремя: {item} мс");
                middleTimeSum += item;
            }
            Console.WriteLine($"\n\nСреднее время: {middleTimeSum/timeArray.Length} мс");

        }
    }
}
