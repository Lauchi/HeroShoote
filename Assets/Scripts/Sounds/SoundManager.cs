using System.Linq;
using UnityEngine;

namespace Sounds
{
    public class SoundManager : MonoBehaviour
    {
        public Sound[] sounds;

        public static SoundManager Instance;
        private void Awake()
        {
            if (Instance != null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }


            DontDestroyOnLoad(this);

            foreach (var sound in sounds)
            {
                sound.source = gameObject.AddComponent<AudioSource>();

                sound.source.clip = sound.clip;
                sound.source.volume = sound.volume;
                sound.source.loop = sound.loop;
            }
        }

        public void Play(string name)
        {
            var sound = sounds.FirstOrDefault(s => s.name == name);
            sound.source.Play();
        }
    }
}