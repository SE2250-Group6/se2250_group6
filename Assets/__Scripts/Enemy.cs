using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    public float speed = 1f;
    public Transform leftPoint, rightPoint;
    Vector3 localScale;
    bool movingRight = false;
    Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
    }

    //Update is called once per frame
    private void Update()
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

    void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }
    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; 

        //play an animation to be done later

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //play animation to be done later
        //animator.SetBool("IsDead", true); 

        //disable enemy
        Destroy(gameObject);
        GetComponent<Collider2D>().enabled = false; 
        this.enabled = false;
        
    }

}
