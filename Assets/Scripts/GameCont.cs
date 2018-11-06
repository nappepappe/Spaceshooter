using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCont : MonoBehaviour
{
    private float deathTimer; //timer
    private bool TimerStart = false; //bool för om timern har startat

    public AudioSource intervention; //audiosource med dödsljudet
    public GameObject player; //object för player
    // Use this for initialization
    void Start()
    {

        deathTimer = 0; //sätter timern till 0
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null && TimerStart == false)
        {
            TimerStart = true; // sätter boolen till true
            deathTimer = 2.1f; //sätter timern till 2.1
            intervention.Play(); //spelar intervention ljudklippet
        }
        if (deathTimer <= 0.1f && deathTimer > 0f) 
        {
            Scene("Game Over"); //laddar scenen med string namnet
        }
        deathTimer -= Time.deltaTime; //gör så att timern räknar ned
    }
    void Scene(string name) //funktion för att byta scene
    {
        SceneManager.LoadScene(name); //byter till scene med namnet man anger när funktionen körs
    }
}
