using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Material material;
    public float forwardForce = 2500f;
    public float horizontalForce = 25f;
    public float verticalForce = 25f;
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
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            //material.color = new Color(Random.value, Random.value, Random.value);
            

        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
