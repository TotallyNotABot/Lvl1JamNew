using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AController : MonoBehaviour
{

    public Vector2 MoveInput = Vector2.zero;
    public Vector2 MoveInputLeft = Vector2.zero;
    public MoveHandAction RightHandControls;
    public MoveHandAction1 LeftHandControls;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTest(InputAction.CallbackContext context)
    {
        MoveInputLeft = context.ReadValue<Vector2>();
    }

    public void OnTest2(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
 

    private void Awake()
    {
        RightHandControls = new MoveHandAction();

        LeftHandControls = new MoveHandAction1();

    }


    private void OnEnable()
    {
        RightHandControls.Enable();
        LeftHandControls.Enable();
    }

    private void OnDisable()
    {
        LeftHandControls.Disable();
        RightHandControls.Disable();
    }
  
}
