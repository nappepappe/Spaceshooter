using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health; //spelarens liv
    private float timer; //timer float

    public GameObject deathSplode; //explosion vid död
    public Text healthText; //text för spelarens liv
    public AudioSource hurtSource; //ljud för när spelaren blir träffad
    public SpriteRenderer sprite; //spelarens sprite

    // Use this for initialization
    void Start()
    {
        hurtSource = GetComponent<AudioSource>(); //hittar komponenten
        timer = 0; //sätter timern till 0
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (health > 0f) //om man har mer än 0 liv
        healthText.text = "Health: " + health.ToString(); //sätter texten till ens liv

        if (timer <= 0) 
        {
            sprite.color = Color.Lerp(sprite.color, Color.white, 10); //sätter spritens färg till vit
        }
        if (health <= 0) //om man inte har något liv kvar
        {
            healthText.text = "Health: 0"; //sätter texten till att man har 0 liv 
            Death(); //kör death funktionen
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") //om man krockar med enemy
        {
            hurtSource.Play(); //spelar ljudet
            timer = 0.1f; //sätter timern till 0.1
            sprite.color = Color.Lerp(sprite.color, Color.red, 10); //sätter färgen till röd
            
        }
        
        if (collision.gameObject.tag == "TankEnemy") //om man krockar med tanken
        {
            health = 0; //insta-kill:ar en
        }
    }
    private void Death() //funktion för ens död
    {
        GameObject splodie = Instantiate(deathSplode, transform.position, transform.rotation); //spawnar dödsexplosionen
        Destroy(gameObject); //förstör spelaren
    }

}
