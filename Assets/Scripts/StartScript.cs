using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public float timer;
    public bool canPlay = false;

    public AudioSource startSource;
    public Text startText;
    // Use this for initialization
    void Start()
    {
        timer = 3f;
        startSource.Play();
    }
    
    private void FixedUpdate()
    {
        if (startText != null)
        startText.text = Mathf.Round(timer).ToString();
        
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            canPlay = true;
            Destroy(startText);
        }
        
    }
}
