using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Material material;
    public float forwardForce = 2500f;
    public float horizontalForce = 25f;
    public float verticalForce = 25f;
    float movement = 0f;
    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }    */
        rb.AddForce(movement * horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
