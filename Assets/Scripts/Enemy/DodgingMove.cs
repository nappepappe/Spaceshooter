using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingMove : EnemyMoveBase
{
    
    protected override void Move()
    {
        rbody.velocity = new Vector2(-5f, 10f * Mathf.Sin(Time.time * 5) * 0.5f);
        //sätter objectets fart till att röra sig i ett sinusvågsmönster i y axeln och åt vänster i x axeln
    }
}
