namespace Julien.Pattern.Mediator
{
    using System.Collections.Generic;

    // Concrete Mediator class
    public class ChatRoom : IChatRoom
    {
        private readonly List<IUser> users = new();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser user)
        {
            foreach (var u in users)
            {
                if (u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }
    }
}