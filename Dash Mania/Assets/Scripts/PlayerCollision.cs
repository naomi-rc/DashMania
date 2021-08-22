using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
