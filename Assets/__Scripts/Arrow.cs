using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float speed = 8f;
    public int damage = 20; 
    public Rigidbody2D rb; 

    //for animation purposes later
    //public GameObject imapctEffect; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        rb.velocity = transform.right * speed; 
    }

    public virtual void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //Debug.Log(hitInfo.name);
        if ((hitInfo.name != "Red Character") && (hitInfo.name != "Purple Character")) {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.TakeDamage(damage); 
            }

            //for animation purposes later 
            //Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
