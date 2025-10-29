using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}