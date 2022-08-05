using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    void Update()
    {
        if (GameObject.Find("ball").transform.position.y < -6) {
            SceneManager.LoadScene("Game Over");
        }
    }
}
