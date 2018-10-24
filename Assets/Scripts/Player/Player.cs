using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float health;

    public GameObject deathSplode;
    public Text healthText;
    // Use this for initialization
    void Start()
    {
        health = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BasicEnemy")
        {
            health = health - 1;
        }
        if (collision.gameObject.tag == "StrongEnemy")
        {
            health = health - 2;
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
