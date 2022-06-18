using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandMovement : MonoBehaviour
{

    public float Speed;
    public Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localPosition -= new Vector3(Input.GetAxisRaw("Horizontal")*Speed,Input.GetAxisRaw("Vertical")*-Speed,0)*Time.deltaTime;
        if(transform.localPosition.x > 6.2f)
        {
            transform.localPosition = new Vector3( 6.2f,transform.localPosition.y,transform.localPosition.z);
        }
        else if(transform.localPosition.x < 5.3f)
        {
            transform.localPosition = new Vector3(5.3f, transform.localPosition.y, transform.localPosition.z);
        }

        if (transform.localPosition.y > 2.63f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 2.63f, transform.localPosition.z);
        }
        else if(transform.localPosition.y < 1.2f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 1.2f, transform.localPosition.z);
        }
        location = transform.localPosition;
    }
}
