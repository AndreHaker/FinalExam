using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public Slider mySlider; // slider is set from 2 to 6 with start value of 4, same as speed in PlayerMovement
    
    public static float speed;


    // Update is called once per frame
    void Update()
    {
        speed = mySlider.value;
     
    }
}