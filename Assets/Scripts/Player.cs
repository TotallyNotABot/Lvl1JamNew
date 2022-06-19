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
    public ClapScript ClapScpt;
    public GameObject Pivot;
    [SerializeField]
    private int playerID = 0;


    private void Start()
    {
      
        GameObject.Find("GameManager").GetComponent<GameManager>().PlayerJoined(Pivot, this.gameObject);
        pointScript = GameObject.Find("PointUIComponent").GetComponent<PointUIScript>();
        pointScript.SetPoints(playerID);
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
    public void SetPlayerID(int playerID)
    {
        this.playerID = playerID;
    }

    public void PlayerClap()
    {
      
        StartCoroutine(HapticFeedback());
        Instantiate(Effect,HandsPosition.transform.position,transform.rotation);
        pointScript.SetPoints(this.playerID);
        Debug.Log("Clapped");
        ClapScpt.PlayAudioSource();
    }



   IEnumerator HapticFeedback()
    {
        GamePad.SetVibration(playerIndex, 1f, 1f);
        yield return new WaitForSeconds(0.5f);
        GamePad.SetVibration(playerIndex, 0, 0);
    }
}
