using Julien.Pattern.Adapter;

using Xunit.Categories;

namespace Julien.Pattern.Tests
{
    [UnitTest]
    public class AdapterTests
    {
        [Fact]
        public void AdapterTest()
        {
            IStandardAudioPlayer adapter = new StandardAudioPlayer();
            adapter.Play("advanced", "myAdvancedAudioFile.wav");
            adapter.Stop();

            // Utilisation de l'adaptateur pour jouer un fichier audio avancé
            var advancedPlayer = new AdvancedAudioPlayer();
            adapter = new AdvancedAudioPlayerAdapter(advancedPlayer);
            adapter.Play("advanced", "myAdvancedAudioFile.wav");
            adapter.Stop();
        }
    }
}