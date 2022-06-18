using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestFlyer : MonoBehaviour
{

    public InputAction _InputSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        _InputSystem.Enable();
    }

    private void OnDisable()
    {
        _InputSystem.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _InputSystem.ReadValue<Vector2>();
    }
}
