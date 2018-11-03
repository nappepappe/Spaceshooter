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
    public bool dodge;
    private bool trettioTre = false;
    private bool trettioTvå = false;

    public GameObject trettiotvå;
    public GameObject trettiotre;
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
        if (score == 32 && trettioTvå == false)
        {
            GameObject trettio = Instantiate(trettiotvå, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            trettioTvå = true;
        }
        else if (score != 32)
        {
            trettioTvå = false;
        }
        if (score == 33 && trettioTre == false)
        {
            GameObject trettio = Instantiate(trettiotre, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            trettioTre = true;
        }
        else if (score != 33)
        {
            trettioTre = false;
        }

        if (score >= 5)
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
        if (score >= 10)
        {
            dodge = true;
        }
    }
}
