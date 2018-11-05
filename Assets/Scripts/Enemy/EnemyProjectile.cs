using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D rbody;
    public AudioSource proSound;
    public GameObject splosion;
    public GameObject startSplosion;
    public Player playerScript;

    public float damage = 1f;
    // Use this for initialization
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<Player>();
        proSound = GetComponent<AudioSource>();
        rbody.rotation = -90;
        proSound.Play();
        GameObject splode1 = Instantiate(startSplosion, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "TankEnemy" && collision.gameObject.tag == "Player")
        {
            playerScript.health = playerScript.health - damage;
            GameObject splode2 = Instantiate(splosion, transform.position, transform.rotation);
            Destroy(gameObject);

        }
      

    }
}