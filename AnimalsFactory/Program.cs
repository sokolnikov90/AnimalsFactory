using BenchmarkDotNet.Running;

namespace AnimalsFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<LegacyAnimalsFactoryPerformanceTests>();
            BenchmarkRunner.Run<AnimalsFactoryPerformanceTests>();
        }
    }
}