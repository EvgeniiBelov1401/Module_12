namespace Exercise_12_01_04
{
    internal class Program
    {
        static void CheckAge()
        {
            const int limitAge = 18;
            Console.Write("Введите Ваш возраст: ");
            int age=int.Parse(Console.ReadLine());

            if (age >= limitAge)
            {
                Console.WriteLine("Вы успешно зпрегистрированы");
            }
            else
            {
                Console.WriteLine($"В регистрации отказано\nВаш возраст меньше {limitAge} лет");
            }
        }
        static void Main(string[] args)
        {
            CheckAge();
        }
    }
}
