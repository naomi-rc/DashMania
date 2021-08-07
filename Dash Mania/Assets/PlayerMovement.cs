using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float horizontalForce = 2000f;
    // Start is called before the first frame update
    private void Start()
    {
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0);
        }
    }
}
