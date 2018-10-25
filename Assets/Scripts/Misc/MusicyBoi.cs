using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicyBoi : MonoBehaviour
{
    public AudioSource musicSource;

    private bool illuminatiConfirmed;

    // Use this for initialization
    void Start()
    { 
        illuminatiConfirmed = false;
        musicSource = GetComponent<AudioSource>();
        musicSource.PlayDelayed(4.5f);
    }

    // Update is called once per frame
    void Update()
    {


        if (GameObject.FindWithTag("TankEnemy") != null)
        {
            illuminatiConfirmed = true;
        }
        else if (GameObject.FindWithTag("TankEnemy") == null)
        {
            illuminatiConfirmed = false;
        }
        if (illuminatiConfirmed == true)
        {
            musicSource.volume = 0f;
        }
        else if (illuminatiConfirmed == false)
        {
            musicSource.volume = 0.25f;
        }
    }
}
