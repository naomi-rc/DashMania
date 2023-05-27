using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            //CinemachineShake.Instance.ShakeCamera(15f, .1f);
            //FindObjectOfType<AudioManager>().Play("PlayerCollision");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
