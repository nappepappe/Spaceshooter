using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject splosion1;
    public GameObject splosion2; //objekt för explosionsprites
    public GameObject splosion3;
    public float timer; //timer
    public AudioSource explodeSound; //ljud för explosionen
    // Use this for initialization
    void Start()
    {
        timer = 0.3f; 

        splosion1.SetActive(true);
        splosion2.SetActive(false); //aktiverar och avaktiverar objekten
        splosion3.SetActive(false);
        explodeSound.Play(); //spelar ljudklippet
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; //timern räknar ned

        if (timer <= 0.2f && timer > 0.1f) //om timern är mellan värdena
        {
            splosion1.SetActive(false);
            splosion2.SetActive(true); //aktiverar och avaktiverar spriteobjekten för att byta utseende
            splosion3.SetActive(false);
        }
        else if (timer <= 0.1f && timer > 0f)
        {
            splosion1.SetActive(false);
            splosion2.SetActive(false); //samma igen men annat objekt som true
            splosion3.SetActive(true);
        }
        else if (timer <= 0f) //om timern är 0
        {
            Destroy(gameObject); //förstör objektet
        }
    }
}
