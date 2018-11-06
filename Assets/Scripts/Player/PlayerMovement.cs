using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public TriggerScript Hitbox1; //hitbox scripts
    public TriggerScript Hitbox2;
    public Rigidbody2D rbody;
    public StartScript startScript; //accessar startscript
    // Use this for initialization
    void Start()
    {
        startScript = GameObject.Find("StartObject").GetComponent<StartScript>(); //hittar komponenten
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && Hitbox1.TriggerOn == false && startScript.canPlay == true) //om man tycker på knappen och kan spela
        {
            rbody.velocity = new Vector2(0, speed); //rör objektet med rätt fart
        }
        else if (Input.GetKey(KeyCode.S) && Hitbox2.TriggerOn == false && startScript.canPlay == true)//om man tycker på knappen och kan spela
        {
            rbody.velocity = new Vector2(0, -speed); //rör objektet med rätt fart
        }
        else
        {
            rbody.velocity = new Vector2(0, 0); //stannar objektet helt
        }
    }
}
