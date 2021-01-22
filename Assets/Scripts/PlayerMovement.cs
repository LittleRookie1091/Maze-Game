using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    //Collision Trigger
    void OnTriggerEnter2D(Collider2D collider){
        //add code here
        
        //Debug.Log("TriggerEnter");
    }  
    void OnTriggerStay2D(Collider2D collider){
        //Debug.Log("TriggerStay");
    }    
    void OnTriggerExit2D(Collider2D collider){
        //Debug.Log("TriggerExit");
    }    


    void OnCollisionEnter2D(Collision2D collision){
        //Debug.Log("CollisionEnter");
    }     
    void OnCollisionExit2D(Collision2D collision){
        //Debug.Log("CollisionExit");
    }      
    void OnCollisionStay2D(Collision2D collision){
        //Debug.Log("CollisionStay");
    } 
}
