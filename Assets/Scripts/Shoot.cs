using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Vector2 velocity;
    public float cooldown = 1f;
    public KeyCode shoot;
    private SpriteRenderer sprite;
    public Vector2 offset = new Vector2(0.4f, 0f);

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKeyDown(shoot))
        {
            GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x, velocity.y);

        }
    }


   
}
