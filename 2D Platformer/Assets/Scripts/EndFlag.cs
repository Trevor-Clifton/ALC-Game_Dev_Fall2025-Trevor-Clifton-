using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public int nextLevelIndex = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (finalLevel)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                SceneManager.LoadScene(nextLevelIndex);
            }
        }
    }
}
