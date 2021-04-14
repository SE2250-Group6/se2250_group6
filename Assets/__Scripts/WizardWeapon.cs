using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardWeapon : Weapon
{
    public float attackRate = 3f;
    float nextAttactTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttactTime)
        {
            Shoot();
            nextAttactTime = Time.time + attackRate;
        }
}
}
