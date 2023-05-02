using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    public bool isSoundPlayer = false;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
       AudioSource audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        if (isSoundPlayer == false)
        {
            audio.Play();
            Debug.Log("Audio is playing");
            isSoundPlayer = true;
        } else
        {
            audio.Pause();
            Debug.Log("Audio is no longer playing");
            isSoundPlayer = false;
        }
    }
}
