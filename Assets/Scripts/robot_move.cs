using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_move : MonoBehaviour
{

    float speedX;
    float speedY;
    public float speed;
    Rigidbody2D rb;
    private bool isFacingRight = true;
    public float jump; //tell chracter how much y component to change

    public Transform inGround; //
    public LayerMask groundLayer; //if touching
    bool isGrounded; //if colliding T/F



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //check which colliders overlap
        //position , expected position, direction of capsule, threshold for collision, colliding with groundlayer
        isGrounded = Physics2D.OverlapCapsule(inGround.position, new Vector2(2.5f,1.0f),CapsuleDirection2D.Horizontal,0,groundLayer); 
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        //speedY = Input.GetAxisRaw("Vertical") * speed; //we are changing for jumping


        if (Input.GetButton("Jump") && isGrounded) //unity will know that its space to jump
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump)); //when jumping y only changes
            //bcus of gravity //simulating real world
        }


        rb.velocity = new Vector2 (speedX, speedY);
        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && speedX > 0f || !isFacingRight && speedX < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
