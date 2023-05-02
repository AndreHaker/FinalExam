using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
   
{
    public GameObject pauseCanvas;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
        pauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ESC key pauses AND resumes

        {
            if (isPaused == false)
             {
                isPaused = true;
                pauseCanvas.SetActive(true);
            }
            else
            {
                isPaused = false;
                pauseCanvas.SetActive(false);
            }
            
        }
    }
}
