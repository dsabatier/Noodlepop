using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public static class AudioMixerExtensions
{
    public static void TransitionToSnapshots(this AudioMixer mixer, AudioMixerSnapshot audioMixerSnapshotFrom, AudioMixerSnapshot audioMixerSnapshotTo, float weightFrom, float weightTo, float timeToReach)
    {
        AudioMixerSnapshot[] audioMixerSnapshots = { audioMixerSnapshotFrom, audioMixerSnapshotTo };
        float[] weights = { 0, 1 };
        mixer.TransitionToSnapshots(audioMixerSnapshots, weights, timeToReach);
    }
}

