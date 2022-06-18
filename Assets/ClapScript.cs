using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapScript : MonoBehaviour
{

    public AudioClip[] ClapClips;
    public AudioSource ClapSource;

    public void PlayAudioSource()
    {
        ClapSource.clip = ClapClips[Random.Range(0, ClapClips.Length)];
        ClapSource.Play();
    }

}
