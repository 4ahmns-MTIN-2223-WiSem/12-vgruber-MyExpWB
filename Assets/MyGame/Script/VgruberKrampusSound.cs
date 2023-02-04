using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberKrampusSound : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource source;
    public bool hasDied;

    bool whichSound = true;

    private void Start()
    {
        hasDied = false;
        foreach (AudioClip item in sounds)
        {
            Debug.Log("Audio Clips for Krampus");
        }
    }

    public void HitSound()
    {
        if (whichSound)
        {
            source.clip = sounds[0];
            whichSound = false;
        }

        else
        {
            source.clip = sounds[1];
            whichSound = true;
        }
        source.Play();
    }

    public void DeathSound()
    {
        if (!hasDied)
        {
            source.clip = sounds[3];
            source.Play();
        }
    }
}
