using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
   public void playAgain() {
   Score.score = 0;
    SceneManager.LoadScene("game");
   }
   private void Start() {
    GameObject.Find("Final Score").gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Final Score: " + Score.score;
   }
}
