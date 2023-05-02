using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Dropdown dropDownLives;
    public static int lives;
    
    // Start is called before the first frame update
    void Start()
    {
        dropDownLives.onValueChanged.AddListener(delegate
            {
            ddLivesChanged(dropDownLives);
        });
    }

    public void ddLivesChanged(Dropdown sender)
    {
        lives = sender.value;
    }
}
