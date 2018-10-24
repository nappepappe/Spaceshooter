using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D franstorm;
    public AudioSource proSound;
    public GameObject splosion;
    public GameObject splody;
    // Use this for initialization
    void Start()
    {
        proSound = GetComponent<AudioSource>();
        franstorm.rotation = -90;
        proSound.Play();
        GameObject splode1 = Instantiate(splody, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject splode2 = Instantiate(splosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
