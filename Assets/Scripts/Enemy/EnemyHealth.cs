using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    private float halfHealth;
    public SpriteRenderer sprite;
    // Use this for initialization
    void Start()
    {
        halfHealth = health / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (health == halfHealth)
        {
            sprite.color = Color.Lerp(Color.white, Color.red, 10);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            health = health - 1;
        }
    }
}
