using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D franstorm; //objektets rigidbody2d
    public AudioSource proSound; //projectilens ljud
    public GameObject explosion; //förstörelseexplosionsobjectet
    public GameObject startExplosion; //explosion vid start
    // Use this for initialization
    void Start()
    {
        proSound = GetComponent<AudioSource>(); //hittar komponenten
        franstorm.rotation = -90; //sätter rotationen till -90
        proSound.Play(); //spelar ljudet
        GameObject splode1 = Instantiate(startExplosion, transform.position, transform.rotation); //spawnar start explosionen
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") //om det man krockar med inte är player
        {
            GameObject splode2 = Instantiate(explosion, transform.position, transform.rotation); //spawna explosionen
            Destroy(gameObject); //förstör objektet

        }
    }
}
