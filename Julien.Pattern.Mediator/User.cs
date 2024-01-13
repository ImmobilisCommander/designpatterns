namespace Julien.Pattern.Mediator
{
    using Microsoft.Extensions.Logging;

    using System;

    // Concrete Colleague class
    public class User : IUser
    {
        private readonly ILogger<User> logger;
        private IChatRoom? chatRoom;
        private string? _name;

        public User(ILogger<User> logger)
        {
            this.logger = logger;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void SetChatRoom(IChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
        }

        public void SendMessage(string message)
        {
            if (chatRoom is not null)
            {
                logger.LogInformation($"{_name} sends message: {message}");
                chatRoom.SendMessage(message, this);
            }
        }

        public void ReceiveMessage(string message)
        {
            logger.LogInformation($"{_name} receives message: {message}");
        }
    }
}