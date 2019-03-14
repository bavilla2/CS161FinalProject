using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Hello");
        SceneManager.LoadScene("Level_1");
    }

    public void MainMenuQuit()
    {
        Application.Quit();
    }
}
