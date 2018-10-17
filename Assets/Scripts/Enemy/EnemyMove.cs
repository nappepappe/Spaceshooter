using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed;
    public Transform fransTorm;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(-moveSpeed, 0f, 0f, Space.World);
    }
}
