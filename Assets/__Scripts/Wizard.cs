using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Enemy
{
    public override void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * speed, rb.velocity.y);
    }
    public override void moveLeft()
    {
        movingRight = false;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(-localScale.x * speed, rb.velocity.y);
    }
}
