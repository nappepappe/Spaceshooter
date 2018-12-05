using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : ProjectileBase
{
    private Player playerScript;

    public float damage = 1f;
    
    protected override void Start()
    {
        base.Start();
        playerScript = GameObject.Find("Player").GetComponent<Player>();
    }
    
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "TankEnemy" && collision.gameObject.tag == "Player")
        {
            playerScript.health = playerScript.health - damage;
            GameObject splode2 = Instantiate(deathExplo, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}