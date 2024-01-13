namespace Julien.Pattern.Command
{
    // La deuxième commande concrète
    internal class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

}