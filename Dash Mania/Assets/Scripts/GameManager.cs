using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public float restartDelay = 1.50f;
    public GameObject levelComplete;
    public void EndGame()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CompleteLevel()
    {
        levelComplete.SetActive(true);
    }
}
