using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundmove : MonoBehaviour
{ 
    public float moveSpeed = 0.5f;
    public float backgroundSize;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector2 offset = new Vector2(Time.time * moveSpeed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}