using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandTrigger : MonoBehaviour
{

    public GameObject Player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            Player.GetComponent<Player>().LeftHandClap = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            Player.GetComponent<Player>().LeftHandClap = false;
        }
    }
}
