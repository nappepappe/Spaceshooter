using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AudioSource))]
public class ProjectileBase : MonoBehaviour
{
    protected Rigidbody2D rbody;
    protected AudioSource sound;
    public GameObject spawnExplo;
    public GameObject deathExplo;
    virtual protected void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>(); //hittar komponenten
    }
    // Use this for initialization
    virtual protected void Start()
    {
        rbody.rotation = -90; //sätter rotationen till -90
        sound.Play(); //spelar ljudet
        GameObject explo1 = Instantiate(spawnExplo, transform.position, transform.rotation); //spawnar start explosionen
    }
    virtual protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") //om det man krockar med inte är player
        {
            GameObject explo2 = Instantiate(deathExplo, transform.position, transform.rotation); //spawna explosionen
            Destroy(gameObject); //förstör objektet

        }
    }
}
