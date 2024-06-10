using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager current;

    public AudioClip drawNoise;
    public AudioClip hoverNoise;
    public AudioClip selectNoise;
    public AudioClip playNoise;

    private AudioSource audioSource;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void DrawSFX()
    {
        audioSource.clip = drawNoise;
        audioSource.Play();
    }

    
}
