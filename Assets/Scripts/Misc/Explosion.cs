using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject splosion1;
    public GameObject splosion2;
    public GameObject splosion3;
    public float timer;
    public AudioSource explodeSound;
    // Use this for initialization
    void Start()
    {
        timer = 0.3f;

        splosion1.SetActive(true);
        splosion2.SetActive(false);
        splosion3.SetActive(false);
        explodeSound.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.2f && timer > 0.1f)
        {
            splosion1.SetActive(false);
            splosion2.SetActive(true);
            splosion3.SetActive(false);
        }
        else if (timer <= 0.1f && timer > 0f)
        {
            splosion1.SetActive(false);
            splosion2.SetActive(false);
            splosion3.SetActive(true);
        }
        else if (timer <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
