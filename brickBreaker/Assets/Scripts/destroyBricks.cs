using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBricks : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "brick") {
            Destroy(other.gameObject);
            Score.score+=100;
        }
    }
}
