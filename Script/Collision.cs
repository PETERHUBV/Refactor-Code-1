using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [Header("Collision")]
    [SerializeField] LayerMask WallLayer;
    [SerializeField] private AudioClip audioclip;
    [SerializeField] private AudioSource audioSource;
   
    private void PlayAudioClip()
    {
        audioSource.Play();
    }
    private void OnCollisionColliderHit(ControllerColliderHit hit)
    {
        if ((WallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            PlayAudioClip();
        }
    }
}