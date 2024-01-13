namespace Julien.Pattern.Adapter
{
    // Interface pour un lecteur audio standard
    public interface IStandardAudioPlayer
    {
        void Play(string audioType, string fileName);
        void Stop();
    }

}