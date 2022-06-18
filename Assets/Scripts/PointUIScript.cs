using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointUIScript : MonoBehaviour
{
    public float PlayerOnePoints;
    public float MaxPoint;

    public Image imgFill;
    public TextMeshProUGUI amountText;

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
        
        UpdateUI();
    }

    public void UpdateUI()
    {
        imgFill.fillAmount = PlayerOnePoints / MaxPoint;
        amountText.text = $"{PlayerOnePoints}/{MaxPoint}";

        if (PlayerOnePoints <= 0)
        {
            PlayerOnePoints = 0;
        }

        if (PlayerOnePoints >= MaxPoint)
        {
            PlayerOnePoints = MaxPoint;
        }
    }


    public void SetPoints()
    {
     
            PlayerOnePoints += pointsValue;
     

        Debug.Log("Fosk");
    }
}
