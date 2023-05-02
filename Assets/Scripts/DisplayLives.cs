using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLives : MonoBehaviour
{
    public int lives;
    public Text text;
    public Button decreaseLives;
    public Button increaseLives;
    // Start is called before the first frame update
    void Start()
    {
        lives = int.Parse(text.text);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Lives.lives.ToString();
    }

    public void IncreaseLives()
    {
        lives = int.Parse(text.text);
        lives += 1;
        text.text = lives.ToString();
    }
    public void DecreaseLives()
    {
        lives = int.Parse(text.text);
        lives -= 1;
        text.text = lives.ToString();
    }
}
