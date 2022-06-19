using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointUIScript : MonoBehaviour
{
    public float[] PlayerPoints;
    public float MaxPoint;

    public Image[] imgFill;
    public TextMeshProUGUI[] amountText;
   

    public bool isGettingPoints;
    public float pointsValue;

    // Update is called once per frame
    void Update()
    {    

        //if (Input.GetKeyDown(KeyCode.Space) && isGettingPoints == true)
        //{
        //    PlayerOnePoints++;
        //}

        //if (Input.GetKeyDown(KeyCode.Space) && isGettingPoints == false)
        //{
        //    PlayerOnePoints--;
        //}
        
       
    }

  


    public void SetPoints(int playerID)
    {
     
            PlayerPoints[playerID-1] += pointsValue;

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


        Debug.Log("Fosk");
    }
}
