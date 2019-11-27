using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ParticleSystemEvent : ScriptableObject
{
    public abstract ParticleSystem Create();
}