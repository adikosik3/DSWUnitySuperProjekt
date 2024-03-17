using UnityEngine;

public class Xgra : MonoBehaviour
{
    public GameObject window;

    public void OpenWindow()
    {
        window.SetActive(true);
    }

    public void CloseWindow()
    {
        window.SetActive(false);
    }
    public void quitButton()
    {
        Application.Quit();
    }
}