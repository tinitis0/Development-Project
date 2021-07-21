using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string Name;
    public AudioClip Clip;
    public AudioMixer Mixer;
    public AudioMixerGroup mixGroup;

    [Range(0f, 1f)]
    public float Volume;
    [Range(0f, 1f)]
    public float Pitch;

    public bool Loop;

    [HideInInspector]
    public AudioSource source;
}
