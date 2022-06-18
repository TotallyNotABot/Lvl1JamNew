using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool inAClap;
    public bool LeftHandClap;
    public bool RightHandClap;
    public AudioSource ClapSound;

  
    void Update()
    {
        if(LeftHandClap && RightHandClap && inAClap != true)
        {
            inAClap = true;
            PlayerClap();
        }
        else
        {
            inAClap = false;
        }
    }

    public void PlayerClap()
    {
        ClapSound.Play();
        Debug.Log("Clapped");
    }
}
