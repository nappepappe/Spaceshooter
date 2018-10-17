using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public bool TriggerOn;
    // Use this for initialization
    void Start()
    {
        TriggerOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        TriggerOn = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TriggerOn = false;
    }
}
