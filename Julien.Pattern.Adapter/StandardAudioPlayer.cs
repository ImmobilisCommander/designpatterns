namespace Julien.Pattern.Adapter
{
    // Implémentation concrète du lecteur audio standard
    public class StandardAudioPlayer : IStandardAudioPlayer
    {
        public void Play(string audioType, string fileName)
        {
            Console.WriteLine("Playing {0} file {1}", audioType, fileName);
        }

        public void Stop()
        {
            Console.WriteLine("Stopping audio playback");
        }
    }

}