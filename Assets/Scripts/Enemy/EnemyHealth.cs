using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public float turnRed;
    private float halfHealth;
    public SpriteRenderer sprite;
    private float timer;
    public GameObject splosion;
    
    public AudioSource hurtSource;

    // Use this for initialization
    void Start()
    {
        halfHealth = health / turnRed;
        hurtSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (health <= 0)
        {
            GameObject die = Instantiate(splosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        if (timer <= 2f && timer > 1.95f)
        {
            sprite.color = Color.Lerp(Color.white, Color.red, 10);
        }
        if (timer <= 2f && timer > 1.97f)
        {
            hurtSource.Play();

        }
        else
        {
            sprite.color = Color.Lerp(sprite.color, Color.white, 10);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health = health - 1;
            timer = 2f;
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
