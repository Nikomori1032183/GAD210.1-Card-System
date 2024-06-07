using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager current;

    [SerializeField] private AudioSource audioSource;

    private void Play(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public AudioClip drawNoise;
    public AudioClip hoverNoise;
    public AudioClip selectNoise;
    public AudioClip playNoise;
}
