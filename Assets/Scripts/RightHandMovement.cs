using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;


public class RightHandMovement : MonoBehaviour
{
  
    public float Speed;
    public Vector3 location;
    public InputAction PInput;
    public InputActionAsset PInputAsset;
    public Vector3 temp;
    public Transform RestPos;
    public Vector2 MoveInput;
    public MoveHandAction RightHandControls;
    public AController RootController;



    private void Start()
    {
      
    }

    private void Awake()
    {
       RightHandControls = new MoveHandAction();
    }


 
    private void OnEnable()
    {
        PInput.Enable();
        PInputAsset.Enable();
       RightHandControls.Enable();
        PInput = RightHandControls.Player.MoveRightBumper;
    }

    private void OnDisable()
    {
        PInput.Disable();
        RightHandControls.Disable();
        PInputAsset.Enable();
       //PInputAsset.FindAction("Move");
        
    }
    // Update is called once per frame
    void Update()
    {

        // Vector2 temp = PInput.ReadValue<Vector2>();

        //transform.localPosition -= new Vector3(Input.GetAxisRaw("RightHandX") *Speed,Input.GetAxisRaw("Vertical")*-Speed,0)*Time.deltaTime;
        MoveInput = RootController.MoveInput;
        temp = new Vector3(MoveInput.x, MoveInput.y, 0);
        transform.localPosition += temp*Speed*Time.deltaTime;
        if(transform.localPosition.x > 6.2f)
        {
            transform.localPosition = new Vector3( 6.2f,transform.localPosition.y,transform.localPosition.z);
        }
        else if(transform.localPosition.x < 5.361f)
        {
            transform.localPosition = new Vector3(5.361f, transform.localPosition.y, transform.localPosition.z);
        }

        if (transform.localPosition.y > 2.63f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 2.63f, transform.localPosition.z);
        }
        else if(transform.localPosition.y < 1.2f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 1.2f, transform.localPosition.z);
        }

        if (PInput.ReadValue<Vector2>().x == 0 && PInput.ReadValue<Vector2>().y == 0)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, RestPos.localPosition, Speed * Time.deltaTime);
        }


        location = transform.localPosition;
    }
}
