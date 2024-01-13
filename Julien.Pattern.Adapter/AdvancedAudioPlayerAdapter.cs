namespace Julien.Pattern.Adapter
{

    // Classe d'adaptateur qui implémente l'interface IStandardAudioPlayer
    public class AdvancedAudioPlayerAdapter : IStandardAudioPlayer
    {
        private AdvancedAudioPlayer _advancedPlayer;

        public AdvancedAudioPlayerAdapter(AdvancedAudioPlayer advancedPlayer)
        {
            _advancedPlayer = advancedPlayer;
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType == "advanced")
            {
                _advancedPlayer.PlayAdvanced(fileName);
            }
            else
            {
                Console.WriteLine("Invalid audio type");
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopping audio playback");
        }
    }
}