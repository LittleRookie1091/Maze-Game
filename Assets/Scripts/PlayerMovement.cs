using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Awake(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void HandleMovement(){
        float moveX = 0f;
        float moveY = 0f;

        if(Input.GetKey(KeyCode.W)){
            moveY = +1f;
        }
        if(Input.GetKey(KeyCode.S)){
            moveY = -1f;
        }
        if(Input.GetKey(KeyCode.A)){
            moveX = -1f;
        }
        if(Input.GetKey(KeyCode.D)){
            moveX = +1f;
        }
        
        Vector3 moveDir = new Vector3(moveX,moveY).normalized;
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //HandleMovement();
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void onTriggerEnter2D(Collider2D collider){
        Debug.Log("TriggerEnter");
    }    

    void onCollisionEnter2D(Collision2D collision){
        Debug.Log("CollisionEnter");
    } 
    void onTriggerExit2D(Collider2D collider){
        Debug.Log("TriggerExit");
    }    

    void onCollisionExit2D(Collision2D collision){
        Debug.Log("CollisionExit");
    } 
    void onTriggerStay2D(Collider2D collider){
        Debug.Log("TriggerStay");
    }    

    void onCollisionStay2D(Collision2D collision){
        Debug.Log("CollisionStay");
    } 
}
