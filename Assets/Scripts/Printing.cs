using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Printing : MonoBehaviour
{
    public Button continueBtn;
    public Button loadBtn;
    public Button saveBtn;
    public Button saveAsJsonBtn;
    public Button newGameBtn;
    public void Continue()
    {
        Debug.Log("Continue");
    }
    public void Load()
    {
        Debug.Log("Load");
    }
    public void Save()
    {
        Debug.Log("Save");
    }
    public void SaveAsJSON()
    {
        Debug.Log("Save As JSON");
    }
    public void NewGame()
    {
        Debug.Log("New Game");
    }
}
