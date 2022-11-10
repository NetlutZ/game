using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake(){
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore(){
        finalScoreText.text = "Your Score is " + scoreKeeper.CalculateScore() + "%";
        if(scoreKeeper.CalculateScore() == 100){
            GameObject.Destroy(GameObject.FindGameObjectWithTag("Acid"));
        }
    }
}
