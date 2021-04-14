using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //public Animator animator;

    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask enemyLayer;

    public int attackDamage = 50;
    public float attackRate = 2f;
    float nextAttactTime = 0f; 

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttactTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttactTime = Time.time + 1f / attackRate; 
            }
        }
    }

    void Attack()
    {
        Debug.Log("attack called");
        //attack animation to be put in later 
        //animator.SetTrigger("Attack"); 

        //detect enemy 
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer); 
        
        //damage enemy
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("collide with enemy");
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage); 
        }
    }

    
}
