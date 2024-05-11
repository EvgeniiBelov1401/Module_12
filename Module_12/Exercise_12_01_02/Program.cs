namespace Exercise_12_01_02
{
    internal class Program
    {
        static void Greeting()
        {
            Console.Write("Как Вас зовут?: ");
            string name = Console.ReadLine();
            string greetings = "Привет, " + name;
            Console.WriteLine(greetings);
        }
        static void Main(string[] args)
        {
            Greeting();
        }
    }
}
