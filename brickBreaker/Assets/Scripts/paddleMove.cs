using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMove : MonoBehaviour
{
    public bool canMove;

    public void _canMove(bool move) {
        canMove = move;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove) {
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.z));
            pos.y = -4.25f;
            pos.z = 0;
            transform.position = pos;
        }
    }
}
