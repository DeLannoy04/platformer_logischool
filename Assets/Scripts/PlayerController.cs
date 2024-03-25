using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;
    private bool isJumping;
    private Rigidbody2D rb;

    private float horizontalMovement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed;
    
        //forgatás
        if(horizontalMovement < 0 ) transform.localEulerAngles = new Vector3(0, 180, 0);
        else if(horizontalMovement > 0 ) transform.localEulerAngles = new Vector3(0, 0, 0);

        if (Input.GetButtonDown("Jump")) isJumping = true;    
    }

    void FixedUpdate()
    {
        Movement(horizontalMovement, isJumping);
    }

    void Movement(float movement, bool isJumping)
    {
        rb.velocity = new Vector2(movement * Time.fixedDeltaTime, rb.velocity.y);

        if(isJumping && GetComponent<CircleCollider2D>().IsTouchingLayers())
        {
            rb.AddForce(new Vector2(0, jumpForce));
            this.isJumping = false;
        }
    }
}
