namespace AnimalsFactoryNetCore
{
public static class LegacyAnimalsFactory
{
    public static Animal CreateAnimalByTernaryOperator(bool isCat)
    {
        return isCat ? (Animal)new Cat() : new Dog();
    }

    public static Animal CreateAnimalByIfElseOperator(bool isCat)
    {
        if (isCat)
            return new Cat();

        return new Dog();
    }
}
}