using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    bool isPause = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    void Pause()
    {
        isPause = !isPause;
        if(isPause)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else {
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
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
