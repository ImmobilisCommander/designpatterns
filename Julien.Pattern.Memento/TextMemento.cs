namespace Julien.Pattern.Memento
{
    /// <summary>
    /// Memento Class
    /// </summary>
    public class TextMemento
    {
        private readonly string? _text;

        public TextMemento(string? text)
        {
            _text = text;
        }

        public string? GetText()
        {
            return _text;
        }
    }
}