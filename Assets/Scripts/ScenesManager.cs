using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene(4);
    }
    public void settingsButton()
    {
        SceneManager.LoadScene(2);
    }
    public void authors()
    {
        SceneManager.LoadScene(3);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void quitButton()
    {
        Application.Quit();
    }
}