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

    private void Update()
    {
        if(Action.ReadValue<float>() > 0)
        {
            SceneRestart();
        }
    }
    public void HoldMe(InputAction.CallbackContext context)
    {
        if (context.performed) // the key has been pressed
        {
            SceneManager.LoadScene("TestScene");
            //dothething
        }
        if (context.canceled) //the key has been released
        {
            //stopdoingthething
        }
    }


    private void OnEnable()
    {
        Action.Enable();
    }

    private void OnDisable()
    {
        Action.Disable();
    }
    public void SceneRestart()
    {
        SceneManager.LoadScene("TestScene");
        Debug.Log("StartPressed");
    }

}
