using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public TriggerScript Hitbox1;
    public TriggerScript Hitbox2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && Hitbox1.TriggerOn == false)
        {
            transform.Translate(0f, speed, 0f, Space.World);
        }
        else if (Input.GetKey(KeyCode.S) && Hitbox2.TriggerOn == false)
        {
            transform.Translate(0f, -speed, 0f, Space.World);
        }
        
    }
}
