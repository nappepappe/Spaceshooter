using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmove : MonoBehaviour
{ 
    public float moveSpeed = 0.5f; //Bakgrundes hastighet
    public float backgroundSize; // Bakgrundens storlek

    private Vector3 startPosition;//Bakgrundens startpos

    void Start()
    {
        startPosition = transform.position; // StartPos är transform.position
    }

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * moveSpeed, 0); //Offset ökar hela tiden
        GetComponent<Renderer>().material.mainTextureOffset = offset;//Visar texturen
    }
}