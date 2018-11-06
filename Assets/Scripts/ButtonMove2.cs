using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove2 : MonoBehaviour
{
    //Funkar likadant som alla texturmove scripts i projektet. Se TseriesMove för kommentarer
    float time;
    Vector3 startPosition;
    Vector3 target = new Vector3(960f, 200f, 0);
    float timeToReachTarget = 0.5f;
    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        time += Time.deltaTime / timeToReachTarget;
        transform.position = Vector3.Lerp(startPosition, target, time);
    }
    public void SetDestination(Vector3 destination, float time)
    {
        time = 0;
        startPosition = transform.position;
        timeToReachTarget = time;
        target = destination;
    }
}
