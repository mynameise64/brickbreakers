using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBricks : MonoBehaviour
{
    public void generate() {
        for (int i = 0; i < 7; i++) {
            for(int j = 0; j < 10; j++) {
                Instantiate(GameObject.Find("brick"),new Vector3((-7.3f)+j*1.6f,1+i/2),transform.rotation);
            }
        }
        Destroy(GameObject.Find("Canvas"));
    }
}
