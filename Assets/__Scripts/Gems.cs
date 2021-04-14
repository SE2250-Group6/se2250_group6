using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Red Character") || col.gameObject.name.Equals("Purple Character"))
        {
            PlayerHealth player = (PlayerHealth)col.gameObject.GetComponent(typeof(PlayerHealth));

            if (player != null)
            {
                player.AddHealth(10);
            }
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
