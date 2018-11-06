using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicyBoi : MonoBehaviour
{
    public AudioSource musicSource; //musikens source

    private bool illuminatiConfirmed; //bool för om illuminati är spawnad

    // Use this for initialization
    void Start()
    { 
        illuminatiConfirmed = false; //sätter bool till false
        musicSource = GetComponent<AudioSource>(); //hittar ljudsource
        musicSource.PlayDelayed(4.5f); //spelar ljudet efter 4.5 sek
    }

    // Update is called once per frame
    void Update()
    {


        if (GameObject.FindWithTag("TankEnemy") != null) //om objektet finns
        {
            illuminatiConfirmed = true; //ILLUMINATICONFIRMED (sätter bool till true)
        }
        else if (GameObject.FindWithTag("TankEnemy") == null) //om den inte finns
        {
            illuminatiConfirmed = false; //sätter till false
        }
        if (illuminatiConfirmed == true) //om den är true 
        {
            musicSource.volume = 0f; //sänk volymen på musiken till 0
        }
        else if (illuminatiConfirmed == false) //om den inte är true
        {
            musicSource.volume = 0.25f; //återställer musiken
        }
    }
}
