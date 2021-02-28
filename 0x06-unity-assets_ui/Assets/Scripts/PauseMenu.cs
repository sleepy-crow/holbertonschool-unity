using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject canv;
    public bool act = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canv.activeSelf)
                Resume();
            else
                Pause();
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        canv.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        canv.SetActive(false);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Options()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
