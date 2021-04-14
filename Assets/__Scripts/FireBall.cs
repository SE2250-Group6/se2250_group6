using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Arrow
{
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        float n = Random.Range(1,10);
        float m = 1 / n; 
        rb.velocity = new Vector2(-1, m) * speed;
    }
    public override void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if ((hitInfo.name != "Wizard Boss") && (hitInfo.name != "enemy"))
        {
            PlayerHealth player = (PlayerHealth)hitInfo.gameObject.GetComponent(typeof(PlayerHealth));

            if (player != null)
            {
                player.TakeDamage(50);
            }
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
