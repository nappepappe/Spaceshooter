using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public Text highscoreText;
    public Text yourScoreText; //texter för scores osv
    public GameObject newHighScore; //objekt för newhighscore
    // Use this for initialization
    void Start()
    {
        newHighScore.SetActive(false); //avaktiverar objektet
        if (PlayerPrefs.GetFloat("playerScore") > PlayerPrefs.GetFloat("Highscore")) //om ens score är högre än ens tidigare highscore
        {
            PlayerPrefs.SetFloat("Highscore", PlayerPrefs.GetFloat("playerScore")); //sätter highscore till ens nya score
            newHighScore.SetActive(true); //aktiverar newhighscore objektet
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("Highscore", 0f); //för att reset:a sin highscore (dev only secret)
        }
        yourScoreText.text = "Your score: " + PlayerPrefs.GetFloat("playerScore").ToString(); //sätter texterna till scores osv
        highscoreText.text = "Highscore: " + PlayerPrefs.GetFloat("Highscore").ToString();

        

    }
}
