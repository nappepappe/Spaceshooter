using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject strongEnemy; //alla fiende objects
    public GameObject basicEnemy;
    public GameObject TankEnemy;
    public GameObject ShootingEnemy;
    public GameObject ShootingDodgingEnemy;
    public GameObject DodgingEnemy;
    public Transform spawnTrans; //transform för var de spawnas
    public Points scoreKeeper; //accessar points scriptet

    private float spawnPosX; //position för spawning på x axeln
    private float spawnTimer;
    private float spawnTimer2;
    private float spawnTimer3;
    private float spawnTimer4; //floats för timers för alla fiender
    private float spawnTimer5;
    private float spawnTimer6;


    // Use this for initialization
    void Start()
    {
        spawnPosX = spawnTrans.position.x; //sätter spawnposx till transformens x värde
        spawnTimer = 5f; //sätter timers till värden
        spawnTimer2 = 4f;
        spawnTimer3 = 4f;
        spawnTimer4 = 4f;
        spawnTimer5 = 4f;
        spawnTimer6 = 4f;
        scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<Points>(); //hittar objektt med scriptet
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        spawnTimer2 -= Time.deltaTime;
        spawnTimer3 -= Time.deltaTime;
        spawnTimer4 -= Time.deltaTime; //timers räknar ned
        spawnTimer5 -= Time.deltaTime;
        spawnTimer6 -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            GameObject spawn = Instantiate(basicEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), basicEnemy.transform.rotation);
            spawnTimer = 2f; //spawnar fienden vid rätt tid och reset:ar tiden
        }
        if (spawnTimer2 <= 0f && scoreKeeper.strong == true)
        {
            GameObject spawn = Instantiate(strongEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), strongEnemy.transform.rotation);
            spawnTimer2 = 4f; //spawnar fienden vid rätt tid och reset:ar tiden
        }
        if (spawnTimer3 <= 0f && scoreKeeper.tank == true)
        {
            GameObject spawn = Instantiate(TankEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), TankEnemy.transform.rotation);
            spawnTimer3 = 30f; //spawnar fienden vid rätt tid och reset:ar tiden
        }
        if (spawnTimer4 <= 0f && scoreKeeper.dodge == true)
        {
            GameObject spawn = Instantiate(DodgingEnemy, new Vector2(spawnPosX, Random.Range(-1, 1)), DodgingEnemy.transform.rotation);
            spawnTimer4 = 10f; //spawnar fienden vid rätt tid och reset:ar tiden
        }
        if (spawnTimer5 <= 0f && scoreKeeper.shooter == true)
        {
            GameObject spawn = Instantiate(ShootingEnemy, new Vector2(spawnPosX, Random.Range(-3f, 4f)), ShootingEnemy.transform.rotation);
            spawnTimer5 = 20f; //spawnar fienden vid rätt tid och reset:ar tiden

        }
        if (spawnTimer6 <= 0f && scoreKeeper.shootDodge == true)
        {
            GameObject spawn = Instantiate(ShootingDodgingEnemy, new Vector2(spawnPosX, Random.Range(-1, 1)), ShootingDodgingEnemy.transform.rotation);
            spawnTimer6 = 25f; //spawnar fienden vid rätt tid och reset:ar tiden
        }
    }
}
