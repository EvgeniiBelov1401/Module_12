using System.Text;

namespace Exercise_12_04_02
{
    internal class Program
    {
        static string UseString(int n)
        {
            var value = "";
            for(int i = 0; i < n; i++)
            {
                value += i.ToString();
                value += " ";
            }
            return value;
        }

        static string UseStringBuilder(int n)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                builder.Append(i.ToString());
                builder.Append(" ");
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            UseString(70000);
            Console.WriteLine("Ready to switch-1");
            Console.ReadKey();

            UseStringBuilder(70000);
            Console.WriteLine("Ready to switch-2");
            Console.ReadKey();
        }
    }
}
