using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject instructionsPanel;

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

    public void Instructions()
    {
        startCanvas.SetActive(false);
        instructionsPanel.SetActive(true);
    }

    public void BackToMain()
    {
        instructionsPanel.SetActive(false);
        startCanvas.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
