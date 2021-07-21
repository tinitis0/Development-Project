using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;


    public static AudioManager instance;

    
    void Awake()
    {

       // if (instance == null)
       //     instance = this;
       // else
       // {
       //     Destroy(gameObject);
       //     return;
       // }
        
       // DontDestroyOnLoad(gameObject);


        foreach (Sound  s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.Clip;
            s.source.outputAudioMixerGroup = s.mixGroup;

            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
            s.source.loop = s.Loop;
        }
    }

    public void Start()
    {
        Play("Rain");
        Play("Music");
        
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found");
            return;
        }

        if (pauseMenu.GameIsPaused)
        {

            s.source.Pause();
        }       

            s.source.Play();
               
    }
}

// FindObjectOfType<AudioManager>().Play("name");