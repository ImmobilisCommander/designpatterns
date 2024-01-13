namespace Julien.Pattern.Visitor
{
    // Interface pour le visiteur
    public interface IVisitor
    {
        void Visit(IVisitable visitable);
    }

}