using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player playerScript; //accessar Player scriptet

    public float damage; //float för skada mot spelaren
    // Use this for initialization
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<Player>(); //hittar spelarobjektet och script komponenten
    }
    
    private void OnTriggerEnter2D(Collider2D collision) //när en krock påbörjas
    {
        if (collision.gameObject.tag == "Player") //om det man krockar med har taggen player 
        {
            playerScript.health = playerScript.health - damage; //tar bort skadans värde från spelarens health

        }
    }
}
