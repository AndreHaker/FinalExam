using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemaningTime : MonoBehaviour
{
    public Text timeLeft;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft.text = SpeedSlider.speed.ToString();
        timer = SpeedSlider.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0) {
            timer -= Time.deltaTime;
            timeLeft.text = timer.ToString();
        }
        
    }
}
