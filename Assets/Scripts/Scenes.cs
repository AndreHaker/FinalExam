using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("2Game");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("3Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}