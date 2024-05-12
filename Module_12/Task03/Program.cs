using BenchmarkDotNet.Running;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = BenchmarkRunner.Run<Testing>();
        }
    }
}
