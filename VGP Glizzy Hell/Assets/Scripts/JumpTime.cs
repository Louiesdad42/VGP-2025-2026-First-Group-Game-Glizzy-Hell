/************************************
 * File name: JumpTime.cs
 * Author: Michael Chiodo
 * Digipen email: michael.chiodo@digipen.edu
 * Course: VGP
 *
 * Description: When the space bar is pressed
 * the player will gain y velocity determined
 * by the jumpAmount variable
 ************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpTime : MonoBehaviour
{
    //sets variables for later
    public float accel = 100;
    private Vector3 inputMovement = Vector3.zero;
    private Rigidbody2D myRb;
    private Animator myAnimator;
    public float jumpAmount = 10;
    public bool isTouching = false;
    public float cooldown = 1f;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //set different components for later use
        myRb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }
    //FixedUpdate is called once per physics update
    private void FixedUpdate()
    {
        myRb.AddForce(inputMovement.normalized * accel);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //when entering a collision with anything, isTouching is true
        isTouching = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer >= cooldown)
        {
            //if the timer is up, set isTouching to false
            isTouching = false;
            timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isTouching == true)
        {
            //when the space bar is pressed, add velocity, and then add to the timer
            myRb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            if (timer < cooldown)
            {
                timer += 1.1f;
            }
        }
    }
}
