using BenchmarkDotNet.Running;

namespace Exercise_12_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = BenchmarkRunner.Run<Testing>();
        }
    }
}
