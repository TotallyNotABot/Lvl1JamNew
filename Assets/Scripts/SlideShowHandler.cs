using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideShowHandler : MonoBehaviour
{
    public bool isClappingCool = false;

    private Coroutine myCoroutine;

    public TextMeshProUGUI ClappingText;

    public PointUIScript script;


    // Start is called before the first frame update
    void Start()
    {

        ClappingText.text = "Clapping: NOT COOL BRO";

        StartCoroutine();
    }

    // Update is called once per frame
    void Update()
    {
        if (isClappingCool)
        {
            ClappingText.text = "Clapping: COOL BRO";
            script.isGettingPoints = true;
        }
        if (!isClappingCool)
        {
            ClappingText.text = "Clapping: NOT COOL BRO";
            script.isGettingPoints = false;
        }
    }

    IEnumerator ChangeClappingState()
    {
        isClappingCool = !isClappingCool;
        yield return new WaitForSeconds(3);
        StartCoroutine();
    }

    public void StartCoroutine()
    {
        myCoroutine = StartCoroutine(ChangeClappingState());
    }
}
