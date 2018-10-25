using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCont : MonoBehaviour
{
    private float deathTimer;
    private bool TimerStart = false;

    public AudioSource intervention;
    public GameObject player;
    // Use this for initialization
    void Start()
    {

        deathTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null && TimerStart == false)
        {
            TimerStart = true;
            deathTimer = 2.1f;
            intervention.Play();
        }
        if (deathTimer <= 0.1f && deathTimer > 0f)
        {
            Scene("Game Over");
        }
        deathTimer -= Time.deltaTime;
    }
    void Scene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
