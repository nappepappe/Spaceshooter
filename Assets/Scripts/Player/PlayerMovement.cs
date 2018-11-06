using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public TriggerScript Hitbox1;
    public TriggerScript Hitbox2;
    public Rigidbody2D rbody;
    public StartScript startScript;
    // Use this for initialization
    void Start()
    {
        startScript = GameObject.Find("StartObject").GetComponent<StartScript>();
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && Hitbox1.TriggerOn == false && startScript.canPlay == true)
        {
            rbody.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S) && Hitbox2.TriggerOn == false && startScript.canPlay == true)
        {
            rbody.velocity = new Vector2(0, -speed);
        }
        else
        {
            rbody.velocity = new Vector2(0, 0);
        }
    }
}
