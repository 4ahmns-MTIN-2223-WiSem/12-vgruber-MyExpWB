using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberKrampusSound : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource source;
    public bool hasDied;

    private void Start()
    {
        hasDied = false;
    }

    public void HitSound()
    {
        source.clip = sounds[0];
        source.Play();
    }

    public void DeathSound()
    {
        if (!hasDied)
        {
            source.clip = sounds[3];
            source.Play();
        }

        if (hasDied)
        {
            
        }
    }
}
