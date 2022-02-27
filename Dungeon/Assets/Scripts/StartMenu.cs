using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startCanvas;

    // Start is called before the first frame update
    void Start()
    {
        startCanvas.SetActive(true);
    }

    public void StartGame()
    {
        startCanvas.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
