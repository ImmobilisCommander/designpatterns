namespace Julien.Pattern.Visitor
{
    // L'interface Visitable
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

}