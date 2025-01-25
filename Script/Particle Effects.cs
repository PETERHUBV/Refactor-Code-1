using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffects : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private ParticleSystem particleSys;
    
    private void PlayParticleEffect()
    {
        particleSys.Play();

    }
}
