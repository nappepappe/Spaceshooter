using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public Text highscoreText;
    public Text yourScoreText;
    public GameObject newHighScore;
    // Use this for initialization
    void Start()
    {
        newHighScore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        yourScoreText.text = "Your score: " + PlayerPrefs.GetFloat("playerScore").ToString();
        highscoreText.text = "Highscore: " + PlayerPrefs.GetFloat("Highscore").ToString();

        if (PlayerPrefs.GetFloat("playerScore") > PlayerPrefs.GetFloat("Highscore"))
        {
            PlayerPrefs.SetFloat("Highscore", PlayerPrefs.GetFloat("playerScore"));
            newHighScore.SetActive(true);
        }
        

    }
}
