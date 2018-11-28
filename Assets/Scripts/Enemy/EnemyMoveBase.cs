using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMoveBase : MonoBehaviour
{
    public float moveSpeed; //float för speed

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    protected abstract void Move();
}
