using Microsoft.Xna.Framework.Audio;
using NewYorkCity1337.Engine;

namespace NewYorkCity1337.Sound
{
    public class LoadedSoundEffect
    {
        private readonly string soundEffectName;
        private const string SoundEffectFolder = "SoundEffect/";

        public LoadedSoundEffect(string soundEffectName)
        {
            this.soundEffectName = soundEffectName;
        }

        public SoundEffect Get()
        {
            return new GameInstance().Load<SoundEffect>(SoundEffectFolder + soundEffectName);
        }
    }
}
