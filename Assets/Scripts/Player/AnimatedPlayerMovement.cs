using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Get animator component
        Animator anim = GetComponent<Animator>();

        // Find trigger to user
        string state_to_trigger = "";
        if (movement.x == 0 && movement.y == 0)  // Not moving 
        {
            state_to_trigger = "stop_walk";
        }
        else if (movement.x < 0)  // Moving left
        {
            state_to_trigger = "walk_west";
        }
        else if (movement.x > 0)  // Moving right
        {
            state_to_trigger = "walk_east";
        }
        else if (movement.y < 0)  // Moving down
        {
            state_to_trigger = "walk_south";
        }
        else if (movement.y > 0)  // Moving up
        {
            state_to_trigger = "walk_north";
        }

        // Trigger animator state change if necessary
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName(state_to_trigger))
        {
            anim.SetTrigger(state_to_trigger + "_trigger");
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    //Collision Trigger
    void OnTriggerEnter2D(Collider2D collider)
    {
        //add code here

        //Debug.Log("TriggerEnter");
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        //Debug.Log("TriggerStay");
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        //Debug.Log("TriggerExit");
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("CollisionEnter");
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("CollisionExit");
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("CollisionStay");
    }
}
