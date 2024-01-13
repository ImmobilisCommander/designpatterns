namespace Julien.Pattern.Mediator
{
    // Colleague interface
    public interface IUser
    {
        void SetName(string name);
        void SendMessage(string message);
        void ReceiveMessage(string message);
        void SetChatRoom(IChatRoom chatRoom);
    }
}