using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDoor : MonoBehaviour
{

    Animator myAnim;
    bool inRange = false;
    bool canvasActive = false;

    int chanceVar;

    public GameObject interactText;
    public GameObject chanceCanvas;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Received keycode E");
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            interactText.SetActive(false);
            canvasActive = true;
            chanceCanvas.SetActive(true);
        }

        if (canvasActive && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Received keycode R");
            Time.timeScale = 1;
            chanceCanvas.SetActive(false);

            chanceVar = Random.Range(1, 3);
            Debug.Log(chanceVar);

            if (chanceVar == 1)
            {
                Debug.Log("dead");
                Time.timeScale = 0;
            }
            if (chanceVar == 2)
            {
                bool isOpen = myAnim.GetBool("isOpen");
                myAnim.SetBool("isOpen", !isOpen);
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                inRange = false;
            }
        }

        else if (canvasActive && Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("Received keycode T");
            chanceCanvas.SetActive(false);
            interactText.SetActive(true);
            Time.timeScale = 1;
            canvasActive = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger zone");
        if (other.gameObject.tag == "Player")
        {
            inRange = true;
            interactText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger zone");
        if (other.gameObject.tag == "Player")
        {
            inRange = false;
            interactText.SetActive(false);
        }
    }
}
