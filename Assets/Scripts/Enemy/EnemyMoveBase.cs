using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBase : MonoBehaviour
{
    public float moveSpeed; //float för speed
    protected Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    protected virtual void Move()
    {
        transform.Translate(-moveSpeed, 0f, 0f, Space.World); //rör objektet åt vänster med speed som hastighet
    }
}
