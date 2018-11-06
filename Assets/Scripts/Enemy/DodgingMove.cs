using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingMove : MonoBehaviour
{
    private Rigidbody2D rbody; //objektets rigidbody2d komponent
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>(); //hittar komponenten
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(-5f, 10f * Mathf.Sin(Time.time * 5) * 0.5f); 
        //sätter objectets fart till att röra sig i ett sinusvågsmönster i y axeln och åt vänster i x axeln
    }
}
