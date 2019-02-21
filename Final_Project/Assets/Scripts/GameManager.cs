using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pausePanel;
    bool isPause = false;
    string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "MainMenu")
        {
            PlayGame();
        }

        if(sceneName != "MainMenu" && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    void PauseGame()
    {
        isPause = !isPause;
        if (isPause)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
