using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D rb;
    float movementSpeed = 3f;
    Vector2 moveDirection;
    bool canMove = true;

    public Camera cam;


    void Update() {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate() {
        //rb.MovePosition(rb.position + moveDirection * movementSpeed * Time.fixedDeltaTime);
        if (canMove) 
            rb.velocity = moveDirection * movementSpeed;
    }
}
