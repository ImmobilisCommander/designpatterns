namespace Julien.Pattern.AbstractFactory
{
    // Implémentation concrète de la factory pour les produits de type A
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

}