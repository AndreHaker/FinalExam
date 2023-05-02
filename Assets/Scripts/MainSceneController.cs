using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneController : MonoBehaviour
{
    public Text nameText;
    public Text speedText;

    private void Start()
    {
        // Retrieve the player preferences for name and speed


        nameText.text = PlayerName.myPlayerName;

        //speedText.text = "Speed: " + SliderValue.speed.ToString();



    }
}
