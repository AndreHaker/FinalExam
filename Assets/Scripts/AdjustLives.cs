using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustLives : MonoBehaviour
{
    public Text Lives;
    public Button decreaseLives;
    public Button increaseLives;
    public int livesCounter;
    // Start is called before the first frame update
    void Start()
    {
       
        
        Lives.text = livesCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void IncreaseLives()
    {
        livesCounter += 1;
        Lives.text = livesCounter.ToString();
    }

    public void DecreaseLives()
    {
        livesCounter -= 1;
        Lives.text = livesCounter.ToString();
    }
}

// Start is called before the first frame update

// Update is called once per frame
