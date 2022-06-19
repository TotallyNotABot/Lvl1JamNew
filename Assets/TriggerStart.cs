using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStart : MonoBehaviour
{

    public GameObject GameMaster;

    public void StartTheGameAss()
    {
        GameMaster.GetComponent<GameManager>().StartTheGame();
    }


}
