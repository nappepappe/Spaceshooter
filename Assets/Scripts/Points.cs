using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int score;  //int för spelarens score
    public bool strong = false; //bools för om fienderna kan spawnas eller inte
    public bool tank = false; //^
    public bool shooter = false; //^
    public bool dodge = false; //^
    public bool shootDodge = false; //^
    private bool trettioTre = false; //bool för om ljudobjectet kan spawnas
    private bool trettioTvå = false; //^

    public GameObject trettiotvå; //ljudobject
    public GameObject trettiotre; //ljudobject
    public Text scoreText; //text för spelarens score
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetFloat("playerScore", 0); //sätter floaten playerScore till 0 (playerprefs för att få access från andra scenes)
        score = 0; //sätter score till 0
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("playerScore", score); //sätter ens "globala" score till scenens score

        if (score > 0) //om score är mer än 0
        scoreText.text = "Score: " + score.ToString(); //får texten att visa poängen

        else if (score <= 0) //annars om score är mindre än eller lika med 0
            scoreText.text = "Score: 0"; //får texten att visa att score är 0

        if (score == 32 && trettioTvå == false) //om man ar 32 poäng och boolen är false
        {
            GameObject trettio = Instantiate(trettiotvå, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f)); //spawnar object
            trettioTvå = true; //sätter boolen till true för att endast spawna ett object
        }
        else if (score != 32) //om man inte har exakt 32 poäng
        {
            trettioTvå = false; //visar att ett objekt kan spawnas om man får 32 igen
        }
        if (score == 33 && trettioTre == false) //om man har exakt 33 poäng och kan spawna ett object
        {
            GameObject trettio = Instantiate(trettiotre, new Vector3(0f, 0f, 0f), new Quaternion(0f, 0f, 0f, 0f)); //spawnar object
            trettioTre = true; //sätter till true
        }
        else if (score != 33) //om man ej har 33
        {
            trettioTre = false; //kan spawna ett till objekt
        }

        if (score >= 5) //om score är mer än eller lika med 5
        {
            strong = true; //sätter bool till true
        }
        if (score >= 30) //om score är mer än eller lika med 30
        {
            tank = true;
        }
        if (score >= 20)//om score är mer än eller lika med 20
        {
            shooter = true;
        }
        if (score >= 10)//om score är mer än eller lika med 10
        {
            dodge = true;
        }
        if (score >= 40) //om score är mer än eller lika med 40
        {
            shootDodge = true;
        }
        if (score <= 0) //om score är mindre än eller lika med 0
        {
            score = 0; //sätter score till 0 för att förhindra minuspoäng
        }
    }
}
