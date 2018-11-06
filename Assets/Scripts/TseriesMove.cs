using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TseriesMove : MonoBehaviour
{

    float time; //Float för hur lång tid förflyttningen ska ta
    Vector3 startPosition; //texturens startposition
    Vector3 target = new Vector3(5f, -2.18f, 0); //Dit texturen ska flyttas
    float timeToReachTarget = 0.5f;//Tiden som det tar för texten att flyttas
    void Start()
    {
        startPosition = transform.position; //Hittar startpositonen
    }
    void Update()
    {
        time += Time.deltaTime / timeToReachTarget; //Räknar upp
        transform.position = Vector3.Lerp(startPosition, target, time);//Sätter value för position
    }
    public void SetDestination(Vector3 destination, float time)// Funktion med namnet SetDestination
    {
        time = 0; // Tiden är 0
        startPosition = transform.position; //startpos
        timeToReachTarget = time; // TimeToReachTarget är time
        target = destination; //Target är destination
    }
}
