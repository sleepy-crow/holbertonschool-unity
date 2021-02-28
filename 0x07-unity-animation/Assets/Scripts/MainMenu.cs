using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Lvl1()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Level02");
    }
    public void Lvl3()
    {
        SceneManager.LoadScene("Level03");
    }
    public void GoOptions()
    {
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
