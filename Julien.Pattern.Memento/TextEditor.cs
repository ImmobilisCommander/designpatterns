namespace Julien.Pattern.Memento
{
    /// <summary>
    /// TextEditor class
    /// </summary>
    public class TextEditor
    {
        private string? _text;

        public void SetText(string text)
        {
            _text = text;
        }

        public TextMemento CreateMemento()
        {
            return new TextMemento(_text);
        }

        public void Restore(TextMemento memento)
        {
            _text = memento.GetText();
        }

        public override string ToString()
        {
            return _text;
        }
    }

}