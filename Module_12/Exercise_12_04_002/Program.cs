using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace Exercise_12_04_002
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Testing>();
        }
    }
}
