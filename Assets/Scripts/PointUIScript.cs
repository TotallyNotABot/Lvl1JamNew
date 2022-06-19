using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PointUIScript : MonoBehaviour
{
    public float[] PlayerPoints;
    public float MaxPoint;

    public Image[] imgFill;
    public TextMeshProUGUI[] amountText;
   

    public bool isGettingPoints;
    public float pointsValue;


    private void Start()
    {
        
    }
    void Update()
    {
       
        //if (Input.GetKeyDown(KeyCode.Space) && isGettingPoints == true)
        //{
        //    PlayerOnePoints++;
        //}

        //if (Input.GetKeyDown(KeyCode.Space) && isGettingPoints == false)
        //{
        //    PlayerOnePoints--;


        for (int i = 0; i < PlayerPoints.Length; i++)
        {
         
            if (PlayerPoints[i] >= MaxPoint)
            {
                switch(i)
                {
                    case 0:
                        SceneManager.LoadScene("Player1Wins");
                        break;
                    case 1:
                        SceneManager.LoadScene("Player2Wins");
                        break;
                    case 2:
                        SceneManager.LoadScene("Player3Wins");
                        break;
                    case 3:
                        SceneManager.LoadScene("Player4Wins");
                        break;
                }
            }
        }


    }

  


    public void SetPoints(int playerID)
    {
     
            PlayerPoints[playerID-1] += pointsValue;
        Debug.Log("Lort");
        imgFill[playerID-1].fillAmount = PlayerPoints[playerID-1] / MaxPoint;
        amountText[playerID-1].text = $"{PlayerPoints[playerID-1]}/{MaxPoint}";

        if (PlayerPoints[playerID-1] <= 0)
        {
            PlayerPoints[playerID-1] = 0;
        }

        if (PlayerPoints[playerID-1] >= MaxPoint)
        {
            PlayerPoints[playerID-1] = MaxPoint;
        }




       
    }
}
