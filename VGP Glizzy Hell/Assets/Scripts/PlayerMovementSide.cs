using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Acceleration")]
    public float accel = 100;
    private Vector3 inputMovement = Vector3.zero;
    private Rigidbody2D myRb;
    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }
    // FixedUpdate is called once per physics update
    private void FixedUpdate()
    {
        myRb.AddForce(inputMovement.normalized * accel);
    }

    // Update is called once per frame
    void Update()
    {
        inputMovement.x = Input.GetAxisRaw("Horizontal");
        if (myAnimator != null && inputMovement != Vector3.zero)
        {
            myAnimator.SetFloat("X", inputMovement.x);
            myAnimator.SetBool("Moving", true);
        }
        else
            myAnimator.SetBool("Moving", false);

    }
}