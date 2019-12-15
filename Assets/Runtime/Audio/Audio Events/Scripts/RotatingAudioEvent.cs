using System;
using UnityEngine;

[CreateAssetMenu(menuName="Audio Events/Rotating")]
public class RotatingAudioEvent : AudioEvent
{
    [Serializable]
    public struct RotatingEntry
    {
        public AudioEvent AudioEvent;
    }
    
    [SerializeField] private RotatingEntry[] _audioEvents = new RotatingEntry[0];
    private int _index = 0;
    
    public override void Play(AudioSource source)
    {
        _audioEvents[_index].AudioEvent.Play(source);
        _index++;
        _index %= _audioEvents.Length;
    }

    [ContextMenu("Restart")]
    public void Restart()
    {
        _index = 0;
    }
}
