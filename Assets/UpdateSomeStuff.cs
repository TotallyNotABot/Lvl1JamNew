using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSomeStuff : MonoBehaviour
{
    public GameObject UiThing;
    public AudioClip[] ChangeAudioClip;
    
    public void Start()
    {
        UiThing = GameObject.Find("PointUIComponent");
    }
    public void UpdateTheStuffo()
    {
        UiThing.GetComponent<SlideShowHandler>().SlideActions();
    }
    public void PlayProjectionSound()
    {
        GetComponent<AudioSource>().clip = ChangeAudioClip[Random.Range(0, ChangeAudioClip.Length)];
        GetComponent<AudioSource>().Play();


    }
}
