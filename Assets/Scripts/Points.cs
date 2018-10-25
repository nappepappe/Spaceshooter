using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int score;
    public bool strong;
    public bool tank;
    public bool shooter;

    public Text scoreText;
    // Use this for initialization
    void Start()
    {
        score = 0;
        strong = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("playerScore", score);
        scoreText.text = "Score: " + score.ToString();

        if (score >= 10)
        {
            strong = true;
        }
        if (score >= 30)
        {
            tank = true;
        }
        if (score >= 60)
        {
            shooter = true;
        }
    }
}
