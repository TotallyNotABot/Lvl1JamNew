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

    public float MaxSlideTime;
    public float MinSlideTime;

    private SpriteRenderer SpriteDisplay;
    public SlideSO[] Slide;
    // Start is called before the first frame update
    void Start()
    {
        SpriteDisplay = GameObject.Find("SpriteDisplay").GetComponent<SpriteRenderer>();
        ClappingText.text = "Clapping: NOT COOL BRO";

        StartCoroutine(ChangeClappingState());
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
        SlideSO CurrentSlide = Slide[Random.Range(0, Slide.Length)];
        SpriteDisplay.sprite = CurrentSlide._Sprite;
        script.pointsValue = CurrentSlide.Points;
        //script.SetPoints();
        float slideTime = Random.Range(MinSlideTime, MaxSlideTime);
        isClappingCool = !isClappingCool;
        yield return new WaitForSeconds(slideTime);
        StartCoroutine(ChangeClappingState());
    }

   
}
