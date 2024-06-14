using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager current;

    public AudioClip drawNoise;
    public AudioClip drawNoise2;

    private AudioSource audioSource;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audioSource.Play();
    }

    public void DrawSFX1()
    {
        audioSource.clip = drawNoise;
        audioSource.pitch = 1f;
    }

    public void DrawSFX2()
    {
        audioSource.clip = drawNoise;
        audioSource.pitch = 0.75f;
    }

    public void DrawSFX3()
    {
        audioSource.clip = drawNoise2;
        audioSource.pitch = 1f;
    }

    public void DrawSFX4()
    {
        audioSource.clip = drawNoise2;
        audioSource.pitch = 0.75f;
    }
}