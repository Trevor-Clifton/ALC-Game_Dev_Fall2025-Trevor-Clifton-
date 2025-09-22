using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon : MonoBehaviour
{
    public int score;
    public int clickToPop;
    public float scaleToIncrease;
    public int scoreToGive;
    private ScoreManager scoreManager;
    public GameObject popEffect;
    GameObject scoreTracker;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        scoreTracker = GameObject.Find("Score");
    }

    void Update()
    {
        if (transform.position.y >= 6.27f)
        {
            scoreTracker.GetComponent<ScoreTracker>().UpdateScore(-scoreToGive);
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        clickToPop -= 1;
        transform.localScale += Vector3.one * scaleToIncrease;
        if (clickToPop == 0)
        {
            //scoreManager.IncreaseScoreText(scoreToGive);
            Instantiate(popEffect, new Vector3(transform.position.x, transform.position.y+1.25f, transform.position.z), transform.rotation);
            scoreTracker.GetComponent<ScoreTracker>().UpdateScore(scoreToGive);
            Destroy(gameObject);
        }
    }
}
