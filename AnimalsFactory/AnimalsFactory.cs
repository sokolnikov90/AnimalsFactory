using System;

namespace AnimalsFactory
{
    public static class AnimalsFactory
    {
        public static Animal CreateAnimalByTernaryOperator(AnimalType animalType)
        {
            return animalType == AnimalType.Cat
                ? new Cat()
                : animalType == AnimalType.Dog
                    ? (Animal)new Dog()
                    : new Parrot();
        }

        public static Animal CreateAnimalByIfElseOperator(AnimalType animalType)
        {
            if (animalType == AnimalType.Cat)
                return new Cat();

            if (animalType == AnimalType.Dog)
                return new Dog();

            return new Parrot();
        }

        public static Animal CreateAnimalBySwitchOperator(AnimalType animalType)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    return new Cat();
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Parrot:
                    return new Parrot();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}