using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile; //objekt för skott
    public Vector2 velocity; //vector2 för hastighet
    
    public KeyCode shoot; //knapp för att skjuta
    bool canShoot = true; //om man kan eller inte kan skjuta
    public Vector2 offset = new Vector2(0.4f, 0f); //en offset vector2
    public StartScript startScript; //accessar startscriptet
    public float timer; //timer

    void Start()
    {
        timer = 0f; //sätter timern till 0
        startScript = GameObject.Find("StartObject").GetComponent<StartScript>(); //hittar komponenten
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if (Input.GetKey(shoot) && timer <= 0f && startScript.canPlay == true) //om man trycker på knappen och man kan skjuta
        {
            GameObject go = Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x, Quaternion.identity);
            //spawnar objektet med rätt rotation och hastighet osv
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x, velocity.y);
            timer = 0.1f; //sätter timer till 0.1
        }

    }


}