﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;
    public float turnRed;
    private float halfHealth;
    public SpriteRenderer sprite;
    private float timer;
    // Use this for initialization
    void Start()
    {
        halfHealth = health / turnRed;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (timer <= 2f && timer > 1.95f)
        {
            sprite.color = Color.Lerp(Color.white, Color.red, 10);
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
        }
        timer = 2f;
    }
}
