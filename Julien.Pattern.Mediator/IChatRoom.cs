namespace Julien.Pattern.Mediator
{
    // Mediator interface
    public interface IChatRoom
    {
        void SendMessage(string message, IUser user);
        void AddUser(IUser user);
    }
}