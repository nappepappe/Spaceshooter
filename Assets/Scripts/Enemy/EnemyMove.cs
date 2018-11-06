using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed; //float för speed

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(-moveSpeed, 0f, 0f, Space.World); //rör objektet åt vänster med speed som hastighet
    }
}
