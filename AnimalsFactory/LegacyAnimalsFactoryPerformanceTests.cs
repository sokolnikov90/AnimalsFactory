using BenchmarkDotNet.Attributes;

namespace AnimalsFactory
{
    public class LegacyAnimalsFactoryPerformanceTests
    {
        [ParamsAllValues]
        public bool IsCat { get; set; }

        [Benchmark]
        public void CreateAnimalByTernaryOperator() =>
            LegacyAnimalsFactory.CreateAnimalByTernaryOperator(IsCat);

        [Benchmark]
        public void CreateAnimalByIfElseOperator() =>
            LegacyAnimalsFactory.CreateAnimalByIfElseOperator(IsCat);
    }
}