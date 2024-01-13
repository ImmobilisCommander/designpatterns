namespace Julien.Pattern.Memento
{
    /// <summary>
    /// Caretaker
    /// </summary>
    public class History
    {
        private readonly Stack<TextMemento> _history = new();

        public void Push(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento Pop()
        {
            return _history.Pop();
        }
    }

}