using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float Timer;
    private void Start()
    {
        StartCoroutine(KillTimer(Timer));
    }
    

    IEnumerator KillTimer(float timer)
    {
        yield return new WaitForSeconds(timer);
    }


}
