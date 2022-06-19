using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartTheScene : MonoBehaviour
{

    public InputAction Action;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Action.ReadValue<float>() > 0)
        {
            Debug.Log("TestScene");
            SceneManager.LoadScene("TestScene");
        }
    }
}
