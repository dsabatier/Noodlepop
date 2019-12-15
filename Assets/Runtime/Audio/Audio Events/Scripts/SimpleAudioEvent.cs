using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName="Audio Events/Simple")]
public class SimpleAudioEvent : AudioEvent
{
	[SerializeField] private AudioClip[] _clips;
	[SerializeField] private RangedFloat _volume;

	[MinMaxRange(0, 2)]
	public RangedFloat pitch;

	public override void Play(AudioSource source)
	{
		if (_clips.Length == 0) return;

		source.clip = _clips[Random.Range(0, _clips.Length)];
		source.volume = Random.Range(_volume.minValue, _volume.maxValue);
		source.pitch = Random.Range(pitch.minValue, pitch.maxValue);
		source.Play();
	}
}