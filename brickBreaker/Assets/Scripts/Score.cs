using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    // TextMeshPro textObject = GameObject.Find("scoreCounter").gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    void Update()
    {
        GameObject.Find("scoreCounter").gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + score;
    }
}
