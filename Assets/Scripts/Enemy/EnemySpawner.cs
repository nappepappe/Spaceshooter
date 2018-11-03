using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject strongEnemy;
    public GameObject basicEnemy;
    public GameObject TankEnemy;
    public GameObject ShootingEnemy;
    public GameObject ShootingDodgingEnemy;
    public GameObject DodgingEnemy;
    public Transform spawnTrans;
    public Points scoreKeeper;

    private float spawnPosX;
    private float spawnTimer;
    private float spawnTimer2;
    private float spawnTimer3;
    private float spawnTimer4;
    private float spawnTimer5;
    private float spawnTimer6;


    // Use this for initialization
    void Start()
    {
        spawnPosX = spawnTrans.position.x;
        spawnTimer = 5f;
        spawnTimer2 = 4f;
        spawnTimer3 = 4f;
        spawnTimer4 = 4f;
        spawnTimer5 = 4f;
        spawnTimer6 = 4f;
        scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        spawnTimer2 -= Time.deltaTime;
        spawnTimer3 -= Time.deltaTime;
        spawnTimer4 -= Time.deltaTime;
        spawnTimer5 -= Time.deltaTime;
        spawnTimer6 -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            GameObject spawn = Instantiate(basicEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), basicEnemy.transform.rotation);
            spawnTimer = 2f;
        }
        if (spawnTimer2 <= 0f && scoreKeeper.strong == true)
        {
            GameObject spawn = Instantiate(strongEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), strongEnemy.transform.rotation);
            spawnTimer2 = 4f;
        }
        if (spawnTimer3 <= 0f && scoreKeeper.tank == true)
        {
            GameObject spawn = Instantiate(TankEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), TankEnemy.transform.rotation);
            spawnTimer3 = 30f;
        }
        if (spawnTimer4 <= 0f && scoreKeeper.dodge == true)
        {
            GameObject spawn = Instantiate(DodgingEnemy, new Vector2(spawnPosX, spawnTrans.position.y), DodgingEnemy.transform.rotation);
            spawnTimer4 = 10f;
        }
        if (spawnTimer5 <= 0f && scoreKeeper.shooter == true)
        {
            GameObject spawn = Instantiate(ShootingEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), TankEnemy.transform.rotation);
            spawnTimer5 = 20f;

        }
        if (spawnTimer6 <= 0f && scoreKeeper.shootDodge == true)
        {
            GameObject spawn = Instantiate(ShootingEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), TankEnemy.transform.rotation);
            spawnTimer6 = 40f;
        }
    }
}
