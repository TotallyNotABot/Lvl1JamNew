using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private int players = 0;
    public Transform[] PlayerSpawns;
    private int maxPlayers = 4;
    [SerializeField]
    GameObject[] PlayerUI;


    public Animator LeftCurtainAnimator;
  
    public Animator PresenterAnimator;




    private void Start()
    {
        StartTheGame();
    }

    public int Players
    {
        get
        {
            return players;
        }
        set
        {
            if(value == 4)
            {
                Debug.Log("Max Players Reached");
            }

            players = value;
            //if(value !> 4 || value !<1)
            //{
            //    players = value;
            //}

        }
    }

    public void StartTheGame()
    {
        if(LeftCurtainAnimator != null)
        {
            LeftCurtainAnimator.Play("Action1");
        }
        
      if(PresenterAnimator != null)
        {
            PresenterAnimator.Play("WalkOnStage");
        }
       
    }

    public void PlayerJoined(GameObject pivotObject, GameObject playerObj)
    {
        PlayerUI[Players].SetActive(true);
        Players++;
        playerObj.GetComponent<Player>().SetPlayerID(Players);
        pivotObject.transform.position = PlayerSpawns[Players-1].position;
    }
}