using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health; //fiendens liv
    public int deathScore; //poängen den ger när den förstörs

    public Points points; //accessar scriptet
    public SpriteRenderer sprite; //fiendens sprite
    public GameObject desExposion; //objectet som är explosionen då fienden dör
    public AudioSource hurtSource; //ljudet för när den blir träffad
    
    private float timer; 

    // Use this for initialization
    void Start()
    {
        hurtSource = GetComponent<AudioSource>(); //hittar komponenten

        points = GameObject.Find("ScoreKeeper").GetComponent<Points>(); //hittar objektet med scriptet på 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; //timer räknar ned
        if (health <= 0) //om den har mindre än eller lika med 0 liv
        {
            points.score = points.score + deathScore; //ökar spelarens score med deathscore
            Death(); //kör funktionen
        }
        if (timer <= 2f && timer > 1.95f) //om timer är mellan värdena
        {
            sprite.color = Color.Lerp(Color.white, Color.red, 10); //ändrar spritens färg till röd
        }
        if (timer <= 2f && timer > 1.97f) //om timer är över värdet
        {
            hurtSource.Play(); //spelar ljudklippet

        }
        else
        {
            sprite.color = Color.Lerp(sprite.color, Color.white, 10); //ändrar tillbaka färgen till dess standardfärg
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile") //om man krockar med projectile
        {
            health = health - 1; //tar bort ett av fiendens liv
            timer = 2f; //sätter timern till 2
        }
        if (collision.gameObject.tag == "Wall") //om man krockar med wall
        {
            if (points.score != 0f) //om man inte har 0 score
                points.score = points.score - deathScore; //tar bort score
            Destroy(gameObject); //förstör objektet

        }
        if (collision.gameObject.tag == "Player") //om man krockar med player
        {
            Death(); //kör funktionen
        }
    }
    void Death()
    {
        GameObject die = Instantiate(desExposion, transform.position, transform.rotation); //spawnar förstörelse explosionen
        Destroy(gameObject); //förstör objektet
    }
}
