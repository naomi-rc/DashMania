using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public float restartDelay = 1.50f;
    public GameObject levelComplete;
    public void EndGame()
    {
        Debug.Log("Game Over!");
        if (!gameOver)
        {
            gameOver = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        Debug.Log("Game Restarted!");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Complete!");
        levelComplete.SetActive(true);
    }
}
