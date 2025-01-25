using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioClip audioclip;
    [SerializeField] private AudioSource audioSource;
    public void PlayAudioClip()
    {
        audioSource.Play();
    }
}
