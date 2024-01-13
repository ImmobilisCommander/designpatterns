namespace Julien.Pattern.Adapter
{
    // Classe pour un lecteur audio avancé qui ne peut pas être utilisé directement
    public class AdvancedAudioPlayer
    {
        public void PlayAdvanced(string fileName)
        {
            Console.WriteLine("Playing advanced audio file {0}", fileName);
        }
    }

}