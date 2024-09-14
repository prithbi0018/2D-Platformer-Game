using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager instance;
    public static SoundManager Instance { get { return instance; } }

    public AudioSource soundEffect; // Source for sound effects
    public AudioSource soundMusic;  // Source for background music
    public SoundType[] Sounds; // Array of sound types
    public bool IsMute = false;
    public float Volume = 1f; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // This will keep the GameObject alive across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetVolume(0.5f);
        PlayMusic(global::Sounds.Music); 
    }
    public void Mute(bool status)
    {
        IsMute = status;
    }
    public void SetVolume (float volume)
    {
        Volume = volume;
        soundEffect.volume = volume;
        soundMusic.volume = volume;
    }





    public void PlayMusic(Sounds sound)
    {
        if (!IsMute)
            return;

        AudioClip clip = getSoundClip(sound); 
        if (clip != null)
        {
            soundMusic.clip = clip;
            soundMusic.Play();
        }
    }

    public void Play(Sounds sound)
    {
        AudioClip clip = getSoundClip(sound); 
        if (clip != null)
        {
            soundEffect.PlayOneShot(clip); 
        }
    }

    private AudioClip getSoundClip(Sounds sound)
    {
        SoundType item = Array.Find(Sounds, item => item.soundType == sound); 
        if (item != null)
            return item.soundClip;
        return null;
    }
}

[Serializable]
public class SoundType
{
    public Sounds soundType;
    public AudioClip soundClip;
}

public enum Sounds
{
    ButtonClick,
    Music,
    PlayerMove,
    PlayerDeath,
    EnemyDeath,
}
