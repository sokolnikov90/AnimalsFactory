using BenchmarkDotNet.Attributes;

namespace AnimalsFactory
{
    public class AnimalsFactoryPerformanceTests
    {
        [ParamsAllValues]
        public AnimalType AnimalType { get; set; }

        [Benchmark]
        public void CreateAnimalByTernaryOperator() =>
            AnimalsFactory.CreateAnimalByTernaryOperator(AnimalType);

        [Benchmark]
        public void CreateAnimalByIfElseOperator() =>
            AnimalsFactory.CreateAnimalByIfElseOperator(AnimalType);

        [Benchmark]
        public void CreateAnimalBySwitchOperator() =>
            AnimalsFactory.CreateAnimalBySwitchOperator(AnimalType);
    }
}