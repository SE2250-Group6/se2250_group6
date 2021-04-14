using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikedBall : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name.Equals("Red Character") || col.gameObject.name.Equals("Purple Character"))
            rb.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Red Character") || col.gameObject.name.Equals("Purple Character"))
        {
            Debug.Log("Got you");
            PlayerHealth player = (PlayerHealth)col.gameObject.GetComponent(typeof(PlayerHealth)); 

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
