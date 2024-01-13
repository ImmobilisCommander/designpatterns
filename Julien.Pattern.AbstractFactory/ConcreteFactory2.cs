namespace Julien.Pattern.AbstractFactory
{
    // Implémentation concrète de la factory pour les produits de type B
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

}