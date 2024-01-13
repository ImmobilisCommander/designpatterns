using Julien.Pattern.AbstractFactory;

using Shouldly;

using Xunit.Categories;

namespace Julien.Pattern.Tests
{
    [UnitTest]
    public class AbstractFactoryTests
    {
        [Fact]
        public void ConcreteFactory1Test()
        {
            IAbstractFactory factory = new ConcreteFactory1();

            IProductA productA = factory.CreateProductA();
            IProductB productB = factory.CreateProductB();

            productA.ShouldNotBeNull();
            productA.ShouldBeOfType<ConcreteProductA1>();

            productB.ShouldNotBeNull();
            productB.ShouldBeOfType<ConcreteProductB1>();
        }

        [Fact]
        public void ConcreteFactory2Test()
        {
            IAbstractFactory factory = new ConcreteFactory2();

            IProductA productA = factory.CreateProductA();
            IProductB productB = factory.CreateProductB();

            productA.ShouldNotBeNull();
            productA.ShouldBeOfType<ConcreteProductA2>();

            productB.ShouldNotBeNull();
            productB.ShouldBeOfType<ConcreteProductB2>();
        }
    }
}