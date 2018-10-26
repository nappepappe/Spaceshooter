using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Vector2 velocity;
    
    public KeyCode shoot;
    bool canShoot = true;
    private SpriteRenderer sprite;
    public Vector2 offset = new Vector2(0.4f, 0f);
    public StartScript startScript;
    public float timer;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        timer = 0f;
        startScript = GameObject.Find("StartObject").GetComponent<StartScript>();
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKey(shoot) && timer <= 0f && startScript.canPlay == true)
        {
            GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x, velocity.y);
            timer = 0.1f;
        }

    }


}