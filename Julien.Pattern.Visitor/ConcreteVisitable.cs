namespace Julien.Pattern.Visitor
{
    // Implémentation de la classe Visitable
    internal class ConcreteVisitable : IVisitable
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string? Property { get; set; }
    }
}