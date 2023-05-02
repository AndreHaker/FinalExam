using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerName : MonoBehaviour
{
    public InputField PlayerNameInput;
    public static string myPlayerName;
    public Text ShowName;



    public void DisplayName()
    {
        myPlayerName = PlayerNameInput.text; 
     
    }
}