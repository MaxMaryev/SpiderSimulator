using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StartMenuButton : MonoBehaviour
{
    [SerializeField] private AudioClip _hover;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();    
    }

    public void PlayOnHower()
    {
        _audioSource.PlayOneShot(_hover);
    }
}