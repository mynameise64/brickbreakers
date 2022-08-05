using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    Rigidbody2D rb;
    float maxSpeed = 10;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    public void _canMove(bool move) {
        rb.gravityScale = 0.5f;
    }
    private void Update() {
        if (rb.velocity.magnitude > maxSpeed){
             rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
         }
         if (transform.position.y > 5) {
            transform.position = new(transform.position.x,0);
         }
    }

    // private void OnCollisionEnter2D(Collision2D other) {
    //     if (other.gameObject.name == "paddle") {
    //         rb.AddForce(new((transform.position.x-other.transform.position.x)/10,0));
    //     }
    // }
}
