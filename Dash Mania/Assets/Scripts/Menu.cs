using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<AudioManager>().StopCurrent();
        FindObjectOfType<AudioManager>().Play("MainTheme");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   
    }
}
