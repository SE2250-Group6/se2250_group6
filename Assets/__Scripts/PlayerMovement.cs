using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float horiMove = 0f;
    public float speed = 40f;
    bool jump = false;
    bool crouch = false;

    public Animator animator; 

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal")); 
        horiMove = Input.GetAxisRaw("Horizontal") * speed; 

        if (Input.GetButtonDown("Jump"))
        {
            jump = true; 
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        //Moving the character
        controller.Move(horiMove * Time.fixedDeltaTime, crouch, jump);
        jump = false; 
    }
}
