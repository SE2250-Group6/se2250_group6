using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    

    public int maxHealth = 100;
    public int currentHealth;

    public float speed = 1f;
    public Transform leftPoint, rightPoint;
    public Vector3 localScale;
    public bool movingRight = false;
    public Rigidbody2D rb;

  

    // Start is called before the first frame update
    public virtual void Start()
    {
        currentHealth = maxHealth;
        

        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();


    }

    //Update is called once per frame
    public virtual void Update()
    {
        if (transform.position.x > rightPoint.position.x)
            movingRight = false;
        if (transform.position.x < leftPoint.position.x)
            movingRight = true;

        if (movingRight)
            moveRight();
        else
            moveLeft(); 
    }

    public virtual void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }
    public virtual void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }

    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        //play an animation to be done later

        if (currentHealth <= 0)
        {   //add 1 point for each enemy killed
            UIManager.singleton.killCount++;
            Die();
            //update it to the game so the new score shows
            UIManager.singleton.UpdateKillCounterUI();
        }
    }

    public virtual void Die()
    {
        //play animation to be done later
        //animator.SetBool("IsDead", true); 

        //disable enemy
        Destroy(gameObject);
        GetComponent<Collider2D>().enabled = false; 
        this.enabled = false;
        
    }

    

}
