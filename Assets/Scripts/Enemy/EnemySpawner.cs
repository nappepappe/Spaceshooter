using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject strongEnemy;
    public GameObject basicEnemy;
    public Transform spawnTrans;
    public Points scoreKeeper;

    private float spawnPosX;
    private float spawnTimer;
    private float spawnTimer2;
    

    // Use this for initialization
    void Start()
    {
        spawnPosX = spawnTrans.position.x;
        spawnTimer = 4f;
        spawnTimer2 = 5f;
        scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        spawnTimer2 -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            GameObject spawn = Instantiate(basicEnemy, new Vector2(spawnPosX, Random.Range(-4f, 4f)), basicEnemy.transform.rotation);
            spawnTimer = 2f;
        }
        if (spawnTimer2 <= 0f && scoreKeeper.strong == true)
        {
            GameObject spawn = Instantiate(strongEnemy, new Vector2(spawnPosX, Random.Range(-4f, 4f)), strongEnemy.transform.rotation);
            spawnTimer2 = 4f;
        }
    }
}
