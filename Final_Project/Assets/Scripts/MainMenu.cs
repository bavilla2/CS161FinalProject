using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject guidePanel;
    public GameObject mainMenuPanel;
    public bool guideOn = false;
    public string level;

    public void StartGame()
    {
        SceneManager.LoadScene(level);
    }

    public void MainMenuQuit()
    {
        Application.Quit();
    }

    public void GuidePanelOn()
    {
        Time.timeScale = 0;
        guidePanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void GuidePanelOff()
    {
        Time.timeScale = 1;
        guidePanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
