using System;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu(menuName="Audio Events/Composite")]
public class CompositeAudioEvent : AudioEvent
{
	[Serializable]
	private struct CompositeEntry
	{
		public AudioEvent Event;
		public float Weight;
	}

	[SerializeField] private CompositeEntry[] _entries;

	public override void Play(AudioSource source)
	{
		float totalWeight = 0;
		for (int i = 0; i < _entries.Length; ++i)
			totalWeight += _entries[i].Weight;

		float pick = Random.Range(0, totalWeight);
		for (int i = 0; i < _entries.Length; ++i)
		{
			if (pick > _entries[i].Weight)
			{
				pick -= _entries[i].Weight;
				continue;
			}

			_entries[i].Event.Play(source);
			return;
		}
	}
}