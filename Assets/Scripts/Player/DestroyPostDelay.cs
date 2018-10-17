using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPostDelay : MonoBehaviour
{
    public int destroyTime;
	void Update ()
    {
        Destroy(gameObject, destroyTime);
	}
}
