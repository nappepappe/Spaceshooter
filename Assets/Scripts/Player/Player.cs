using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health;
    private float timer;

    public GameObject deathSplode;
    public Text healthText;
    public AudioSource hurtSource;
    public SpriteRenderer sprite;

    // Use this for initialization
    void Start()
    {
        health = 5f;
        hurtSource = GetComponent<AudioSource>();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        healthText.text = "Health: " + health.ToString();

        if (timer <= 0)
        {
            sprite.color = Color.Lerp(sprite.color, Color.white, 10);
        }
        if (health <= 0)
        {
            Death();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            hurtSource.Play();
            timer = 0.1f;
            sprite.color = Color.Lerp(sprite.color, Color.red, 10);
            
        }
        
        if (collision.gameObject.tag == "TankEnemy")
        {
            health = 0;
        }
    }
    private void Death()
    {
        GameObject splodie = Instantiate(deathSplode, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
