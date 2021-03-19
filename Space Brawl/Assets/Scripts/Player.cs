using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed;   //how fast the character can move
    private float input; //we ertreive information from keys press.



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
        //Inside Unity we assign parameters in our animator.. If 'true' then the character will be in Idle; however, else (if) false
        //then the character 'Run'
        if (input != 0)
        {
            anim.SetBool("IsRunning", true); //Character will be Idle
        }
        else
        {
            anim.SetBool("IsRunning", false); //character will Run
        }

        
        //Setting the rotation values of an object (player)
        if (input > 0)
        {
            //To make sure the object has zero rotation
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0)
        {
            //If input is less than zero then it is running to the left
            transform.eulerAngles = new Vector3(0, 180, 0);
        }



    }

    void FixedUpdate()
    {
        //stores a number from -1 to 1 depending on the arrow keys the person presses
        input = Input.GetAxisRaw("Horizontal"); 

        //moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

}
