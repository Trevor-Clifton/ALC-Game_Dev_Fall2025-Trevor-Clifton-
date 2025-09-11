using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private int score;
    TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateScore(int addition)
    {
        score += addition;
        scoreText.text = "Score: " + score;
    }
}
