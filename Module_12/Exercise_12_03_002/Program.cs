namespace Exercise_12_03_002
{
    internal class Program
    {
        static void CreateArray(int[]array)
        {
            Random random = new Random();

            for (int i= 0;i < array.Length;i++)
            {               
                array[i] = random.Next(1, 100);
            }
        }
        static void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Thread.Sleep(300);
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        static void SortArray(int[] array, ref int count)
        {
            int tmp= 0;
            
            for (int i = 0; i < array.Length-1;i++)
            {
                for (int j = i+1; j < array.Length;j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;

                        count++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int counter=0;
                int[] array = new int[10];

                CreateArray(array);
                ShowArray(array);

                Console.WriteLine("Сортировать массив");
                Console.ReadLine();

                SortArray(array,ref counter);
                ShowArray(array);
                Console.WriteLine($"Кол-во действий: {counter}");

                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
