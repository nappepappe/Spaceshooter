using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public bool TriggerOn; //om man nuddar
    // Use this for initialization
    void Start()
    {
        TriggerOn = false; //sätter till false
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall") //om man nuddar en vägg
        TriggerOn = true; //sätter bool till true
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TriggerOn = false; //sätter till false när man slutar nudda något
    }
}
