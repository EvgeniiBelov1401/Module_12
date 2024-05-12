using System.Diagnostics;

namespace Task02
{
    internal class Program
    {
        static List<int> CreateList()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 10000; i++)
            {

                list.Add(random.Next(1000));
            }
            return list;
        }

        static void ShowList(List<int> list)
        {
            //for (int i = 0;i < list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            //var time =new Stopwatch();
            var nonSortedList=CreateList();

            ShowList(nonSortedList);

            Console.WriteLine("Сортировать список...");
            //Console.ReadLine();

            var sortedList=nonSortedList;
            //time.Start();
            sortedList.Sort();
            //time.Stop();
            ShowList(sortedList);

            //Console.WriteLine($"\n\nВремя сортировки: {time.ElapsedMilliseconds} мс");
        }
    }
}
