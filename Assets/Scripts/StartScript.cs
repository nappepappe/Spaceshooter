using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public float timer; //float för timer
    public bool canPlay = false; //bool för om man kan spela

    public AudioSource startSource; 
    public Text startText; //text för startnedräkningen
    // Use this for initialization
    void Start()
    {
        timer = 3f; //sätter timer till 3
        startSource.Play(); //spelar startljudklippet
    }
    
    private void FixedUpdate()
    {
        if (startText != null) //om  starttexten finns i scenen
        startText.text = Mathf.Round(timer).ToString(); //gör texten till timern 
        
        timer -= Time.deltaTime; //timer räknar ned
        if (timer <= 0f) //om timer är mindre än eller lika med 0
        {
            canPlay = true; //visar att man kan spela
            Destroy(startText); //förstör starttexten
        }
        
    }
}
