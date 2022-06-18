using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeftHandMovement : MonoBehaviour
{

    public float Speed;
    public Vector3 location;
    public InputAction PInput;
    public Vector3 temp;
    public Transform RestPos;
    public Vector2 MoveInput;
    public MoveHandAction1 LeftHandControls;
    public AController RootController;

    private void Awake()
    {
        LeftHandControls = new MoveHandAction1();
    }

    // Start is called before the first frame update
    private void OnEnable()
    {
        PInput.Enable();
        LeftHandControls.Enable();
        PInput = LeftHandControls.Player.MoveLeftBumper;
    }

    private void OnDisable()
    {
        PInput.Disable();
        LeftHandControls.Disable();
    }
    // Update is called once per frame
    void Update()
    {

        //transform.localPosition -= new Vector3(Input.GetAxisRaw("Horizontal")*Speed,Input.GetAxisRaw("Vertical")*-Speed,0)*Time.deltaTime;
        MoveInput = RootController.MoveInputLeft;
        temp = new Vector3(MoveInput.x, MoveInput.y, 0);
        transform.localPosition += temp * Speed * Time.deltaTime;

        if (transform.localPosition.x > 5.3f)
        {
            transform.localPosition = new Vector3(5.3f, transform.localPosition.y, transform.localPosition.z);
        }
        else if (transform.localPosition.x < 4.6f)
        {
            transform.localPosition = new Vector3(4.6f, transform.localPosition.y, transform.localPosition.z);
        }

        if (transform.localPosition.y > 2.638f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 2.638f, transform.localPosition.z);
        }
        else if (transform.localPosition.y < 1.314f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 1.314f, transform.localPosition.z);
        }

        if(PInput.ReadValue<Vector2>().x == 0 && PInput.ReadValue<Vector2>().y == 0)
        {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, RestPos.localPosition, Speed*Time.deltaTime);
        }

        location = transform.localPosition;
    }
}
