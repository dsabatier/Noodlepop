using System;
using UnityEngine;

[CreateAssetMenu(menuName="Particle System Events/Simple")]
public class SimpleParticleSystemEvent : ParticleSystemEvent
{
    [SerializeField] private GameObject _prefab;
    public override ParticleSystem Create()
    {
        GameObject go = Instantiate(_prefab, Vector3.zero, Quaternion.identity);
        ParticleSystem particleSystem = go.GetComponent<ParticleSystem>();
        return particleSystem;
    }
}
