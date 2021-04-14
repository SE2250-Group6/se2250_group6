using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Text healthText;
    public Text dieText;

    public float damageRate = 12f;
    float nextDamageTime = 0f;

    public Transform mainPoint;
    public float range = 0.2f;
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        dieText.text = " ";
        currentHealth = maxHealth;
        SetHealthText();
    }

    void Update()
    {
        
            detectCollison();
        
    }

    /*
    void OnTriggerEnter(Collider hitInfo)
    {

        if (hitInfo.gameObject.name.Equals("enemy"))
        {
            Debug.Log("collided with enemy");
            TakeDamage(10);
        }
        if (hitInfo.gameObject.name.Equals("spiked ball"))
        {
            Debug.Log("collided with ball");
            TakeDamage(10);
        }


        SetHealthText(); 
    }
    */ 

    void detectCollison()
    {
        //detect enemy 
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(mainPoint.position, range, enemyLayer);

        //damage enemy
        foreach (Collider2D enemy in hitEnemies)
        {
            if (Time.time >= nextDamageTime)
            {
                TakeDamage(10);
                nextDamageTime = Time.time + damageRate;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Spikes")
        {
            Die(); 
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        SetHealthText();
        //play an animation to be done later

        if (currentHealth <= 0)
        {

            Die();
        }
    }
    public void AddHealth(int health)
    {
        currentHealth += health;
        SetHealthText();
    }

    void Die()
    {
        //play animation to be done later
        //animator.SetBool("IsDead", true); 

        healthText.text = "Health: " + 0;
        //this.GetComponent<Renderer>().enabled = false;
        this.gameObject.SetActive(false);
        dieText.text = "You've Died! Time to restart.";
        Invoke("Restart", 2); 
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void SetHealthText()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }
}
