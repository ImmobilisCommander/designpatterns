namespace Julien.Pattern.AbstractFactory
{
    // Définition de l'interface pour l'Abstract Factory
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

}