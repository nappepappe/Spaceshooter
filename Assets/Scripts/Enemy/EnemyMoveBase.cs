using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
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
        rbody.velocity = new Vector2(-moveSpeed, 0f);//rör objektet åt vänster med speed som hastighet
    }
}
