using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{

    public float speed;   //how fast the character can move
    private float moveInput; //we retreive information from keys press.
    public float jumpForce;

    public Transform groundPos;
    private bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimerCounter;
    public float jumptime;
    private bool isJumping;
    private bool doubleJump;



    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);



        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            //anim.SetTrigger("Jumping with Gun");
            isJumping = true;
            jumpTimerCounter = jumptime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isGrounded == true)
        {
            doubleJump = false;
            anim.SetBool("IsJumping", false);
        }
        else
        {
            anim.SetBool("IsJumping", true);
        }

        //Inside Unity we assign parameters in our animator.. If 'true' then the character will be in Idle; however, else (if) false
        //then the character 'Run'
        if (moveInput != 0)
        {
            anim.SetBool("IsRunning", true); //Character will be Idle
        }
        else
        {
            anim.SetBool("IsRunning", false); //character will Run
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimerCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimerCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }


        if(isGrounded == false && doubleJump == false && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            doubleJump = true;
            isJumping = true;
            jumpTimerCounter = jumptime;
            rb.velocity = Vector2.up * jumpForce;
        }


        
        //Setting the rotation values of an object (player)
        if (moveInput > 0)
        {
            //To make sure the object has zero rotation
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveInput < 0)
        {
            //If input is less than zero then it is running to the left
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void FixedUpdate()
    {
        //stores a number from -1 to 1 depending on the arrow keys the person presses
        moveInput = Input.GetAxisRaw("Horizontal");

        //moving player
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }


}
