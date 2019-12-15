using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Noodlepop.SingletonPattern;

namespace Noodlepop.Audio
{
    public class AudioMixManager : Singleton<AudioMixManager>
    {

        [SerializeField] private AudioMixer _masterAudioMixer;
        [SerializeField] private AudioMixer _menuAudioMixer;


        // TODO: Right now these mixers are exposed more freely than I would like
        // Should create an enum or something and call mixer functions through this manager
        //
        // ie. AudioMixManager.TransitionToSnapshots(Mixers.MAIN_MENU, snapshots, weights, timeToReach);
        public static AudioMixer MasterAudioMixer
        {
            get { return Instance._masterAudioMixer; }
        }

        public static AudioMixer MenuAudioMixer
        {
            get { return Instance._menuAudioMixer; }
        }

        private readonly string SFX_VOLUME = "SFX Volume";
        private readonly string MUSIC_VOLUME = "Music Volume";

        public static void SetSoundEffectsVolume(float volume)
        {
            Instance.SetSoundEffectsVolume_Internal(volume);
        }

        public static void SetMusicVolume(float volume)
        {
            Instance.SetMusicVolume_Internal(volume);
        }

        private void SetSoundEffectsVolume_Internal(float volume)
        {
            _masterAudioMixer.SetFloat(SFX_VOLUME, 20f * Mathf.Log10(volume));
        }

        private void SetMusicVolume_Internal(float volume)
        {
            _masterAudioMixer.SetFloat(MUSIC_VOLUME, 20f * Mathf.Log10(volume));
        }
    }
}