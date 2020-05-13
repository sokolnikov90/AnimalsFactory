using BenchmarkDotNet.Running;

namespace AnimalsFactoryNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<LegacyAnimalsFactoryPerformanceTests>();
            BenchmarkRunner.Run<AnimalsFactoryPerformanceTests>();
        }
    }
}