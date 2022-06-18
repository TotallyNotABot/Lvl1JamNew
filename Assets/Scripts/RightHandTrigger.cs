using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandTrigger : MonoBehaviour
{
    public GameObject Player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            Player.GetComponent<Player>().RightHandClap = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            Player.GetComponent<Player>().RightHandClap = false;
        }
    }
}
