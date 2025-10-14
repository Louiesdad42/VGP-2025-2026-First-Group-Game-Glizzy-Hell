using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JumpTime : MonoBehaviour
{
    [Tooltip("Acceleration")]
    public float accel = 100;
    private Vector3 inputMovement = Vector3.zero;
    private Rigidbody2D myRb;
    private Animator myAnimator;
    public float jumpAmount = 10;
    public bool isTouching = false;
    // Start is called before the first frame update
    void Start()
    {
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
        isTouching = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        isTouching = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isTouching == true)
        {
            myRb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        } 
    }
}
