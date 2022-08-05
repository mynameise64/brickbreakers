using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    void Update()
    {
        if (Score.score >= 7000) {
            SceneManager.LoadScene("win");
        }
    }
}
