using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyMove : EnemyMoveBase
{
    protected override void Move()
    {
        transform.Translate(-moveSpeed, 0f, 0f, Space.World); //rör objektet åt vänster med speed som hastighet
    }
}
