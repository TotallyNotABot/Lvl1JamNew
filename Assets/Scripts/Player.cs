using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class Player : MonoBehaviour
{
    private bool inAClap;
    public bool LeftHandClap;
    public bool RightHandClap;
    private bool hasClapped = false;
    public AudioSource ClapSound;

    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;
    public Transform HandsPosition;
    public GameObject Effect;
    PointUIScript pointScript;


    private void Start()
    {
        pointScript = GameObject.Find("PointUIComponent").GetComponent<PointUIScript>();
    }
    void Update()
    {
        if(LeftHandClap && RightHandClap && inAClap != true)
        {
            inAClap = true;
            PlayerClap();
            hasClapped = true;
        }
        else if(LeftHandClap && RightHandClap && hasClapped)
        {
            
        }
        else
        {
            inAClap = false;
            hasClapped = false;
        }
    }

    public void PlayerClap()
    {
        ClapSound.Play();
        StartCoroutine(HapticFeedback());
        Instantiate(Effect,HandsPosition.transform.position,transform.rotation);
        pointScript.SetPoints();
        Debug.Log("Clapped");
    }



   IEnumerator HapticFeedback()
    {
        GamePad.SetVibration(playerIndex, 1f, 1f);
        yield return new WaitForSeconds(0.5f);
        GamePad.SetVibration(playerIndex, 0, 0);
    }
}
