using UnityEngine.SceneManagement;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("currentScene", SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next()
    {
        if (PlayerPrefs.GetInt("currentScene") < 4)
            SceneManager.LoadScene(PlayerPrefs.GetInt("currentScene") + 1);
        else
            SceneManager.LoadScene(0);
    }
}
