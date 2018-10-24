using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public float timer;
    public AudioSource startSource;

    // Use this for initialization
    void Start()
    {
        timer = 3f;
        startSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }
}
