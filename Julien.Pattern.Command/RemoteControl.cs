namespace Julien.Pattern.Command
{
    public class RemoteControl
    {
        private readonly ICommand onCommand;
        private readonly ICommand offCommand;

        public RemoteControl(IEnumerable<ICommand> commands)
        {
            onCommand = commands.OfType<LightOnCommand>().First();
            offCommand = commands.OfType<LightOffCommand>().First();
        }

        public void PressOnButton()
        {
            onCommand.Execute();
        }

        public void PressOffButton()
        {
            offCommand.Execute();
        }
    }
}