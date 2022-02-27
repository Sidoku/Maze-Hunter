using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public GameObject winCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Reached the goal!");
        if (other.gameObject.tag == "Player")
        {
            winCanvas.SetActive(true);
            StartCoroutine(EndGame());
        }
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        Time.timeScale = 0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
